using System;
using System.Net;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using StockWatcher.MerrillLynch.Serializers.Objects;
using StockWatcher.MerrillLynch.Serializers.Requests;
using StockWatcher.MerrillLynch.Serializers.Responses;

namespace StockWatcher.MerrillLynch
{
    public class MerrillLynchScraper : IStockScraper
    {
        private readonly string userAgent;

        private readonly string username;

        private readonly string password;

        private CookieContainer cookies;

        private ChromeDriverService driverService;

        private ChromeDriver driver;

        private string pageId;

        public MerrillLynchScraper(string userAgent, string username, string password)
        {
            this.userAgent = userAgent;
            this.username = username;
            this.password = password;
        }

        public void Start()
        {
            driverService = ChromeDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;

            // hide the window off screen if we're not in debug mode
            ChromeOptions options = new ChromeOptions();
            options.AddArgument($"--user-agent={userAgent}");
            #if !DEBUG
            options.AddArgument("--window-position=-32000,-32000");
            #endif

            const string loginUrl = "https://olui2.fs.ml.com/login/login.aspx";
            driver = new ChromeDriver(driverService, options);
            driver.Url = loginUrl;
            driver.Navigate();
            IWebElement e = driver.FindElementById("txtUserid");
            e.SendKeys(username);
            e = driver.FindElementById("txtPassword");
            e.SendKeys(password);
            e = driver.FindElementById("btnValidate");
            e.Click();

            while (driver.Url == loginUrl)
            {
                Thread.Sleep(250);
            }

            UpdateCookies();
            UpdatePageId();
        }

        private void NavigateTo(string uri)
        {
            driver.Url = uri;
            driver.Navigate();

            UpdatePageId();
            UpdateCookies();
        }

        private TResponse ExecuteRequest<TResponse>(AbstractReq<TResponse> req)
            where TResponse : class
        {
            if (req.RequestReferer != null)
            {
                NavigateTo(req.RequestReferer);
            }

            return req.GetResponse(userAgent, new Uri(driver.Url), cookies, pageId);
        }

        private void UpdatePageId()
        {
            pageId = driver.FindElementById("__PageIdField").GetAttribute("value");
        }

        private void UpdateCookies()
        {
            cookies = new CookieContainer();
            foreach (OpenQA.Selenium.Cookie c in driver.Manage().Cookies.AllCookies)
            {
                string name = c.Name;
                string value = c.Value;
                cookies.Add(new System.Net.Cookie(name, value, c.Path, c.Domain));
            }
        }

        public GetQuoteResp TestGetData()
        {
            return ExecuteRequest(new GetQuoteReq
            {
                Data = new StockDataReqData
                {
                    InstrumentID = "TSLA",
                    InstrumentIDType = 5,
                    AdditionalRequest = new StockDataReqData
                    {
                        InstrumentID = ""
                    }
                }
            });
        }

        public SubmitOrderResp TestBuy()
        {
            ValidateOrderResp vresp = ExecuteRequest(new ValidateOrderReq
            {
                Data = new EquityTradeTicketDisc
                {
                    EquityTradeTicket = new EquityTradeTicket(true)
                    {
                        ActionType = EquityTradeTicketDisc.ActionType.Buy,
                        ExecutionContextIndex = "6",
                        SymbolId = "TSLA",
                        Quantity = 1,
                        AccountIdentifier = new ReqAccountIdentifier
                        {
                            Type = "Account",
                            Index = 1
                        },
                        Price = 100,
                        Duration = EquityTradeTicketDisc.Duration.Day,
                        OrderType = EquityTradeTicketDisc.OrderType.Limit,
                        TLTData =
                            "{\"TaxLotInput\":{\"AccountIndex\":-1,\"Action\":\"\",\"SecurityNumber\":\"\",\"ProductClassCode\":\"\",\"Symbol\":\"\",\"SpecifiedShares\":0,\"TradingSessionEnum\":0},\"Quantity\":0,\"UserSelectionData\":null,\"IsUserDataEntered\":false,\"UserSortedColumn\":\"\",\"UserSortedOrderAsec\":false}"
                    },
                    Disclaimers = "D439,D440,D450,D351,D955,D1083,D567",
                    SafePassRequest = new SafePassRequest
                    {
                        SafePassFunction = "Trading",
                        CurrentApplication = 1,
                        ShowSafePassIntroPanel = true,
                        ShowSafePassEntryPanel = true,
                        SafePassControlClientId =
                            "ctl00_ctl00_ctl00_cphSiteMst_cphNestedPage_cphStage_view1_PilotPreviewConfirmPage_SafePassControl",
                        IntroHeaderRDN = "RDN_SafePass",
                        IntroFooterRDN = "RDN_SafePassSectionIntro",
                        EntryHeaderRDN = "RDN_SafePass",
                        EntryMidRDN = "RDN_SafePass",
                        EntryFooterRDN = "RDN_SafePassSectionIntro",
                        CurrentRUN = "RUN_Equities_OrderPreview",
                        IsIntroHeaderContentParamsBased = true,
                        IsIntroFooterContentParamsBased = true,
                        IsEntryHeaderContentParamsBased = true,
                        IsEntryFooterContentParamsBased = true,
                        IsEntryMidContentParamsBased = true,
                        CurrentMode = 9
                    }
                }
            });

            return ExecuteRequest(new SubmitOrderReq
            {
                Data = new EquityTradeTicketDisc
                {
                    EquityTradeTicket = new EquityTradeTicket(false)
                    {
                        ActionType = EquityTradeTicketDisc.ActionType.Buy,
                        ExecutionContextIndex = "6",
                        SymbolId = "TSLA",
                        Quantity = 1,
                        AccountIdentifier = new ReqAccountIdentifier
                        {
                            Type = "Account",
                            Index = 1
                        },
                        Price = 100,
                        Duration = EquityTradeTicketDisc.Duration.Day,
                        OrderType = EquityTradeTicketDisc.OrderType.Limit,
                        TLTData =
                            "{\"TaxLotInput\":{\"AccountIndex\":-1,\"Action\":\"\",\"SecurityNumber\":\"\",\"ProductClassCode\":\"\",\"Symbol\":\"\",\"SpecifiedShares\":0,\"TradingSessionEnum\":0},\"Quantity\":0,\"UserSelectionData\":null,\"IsUserDataEntered\":false,\"UserSortedColumn\":\"\",\"UserSortedOrderAsec\":false}"
                    },
                    Disclaimers = "D439,D440,D450,D351,D955,D1083,D567",
                    SafePassRequest = new SafePassRequest
                    {
                        SafePassFunction = "Trading",
                        CurrentApplication = 1,
                        ShowSafePassIntroPanel = true,
                        ShowSafePassEntryPanel = true,
                        SafePassControlClientId =
                            "ctl00_ctl00_ctl00_cphSiteMst_cphNestedPage_cphStage_view1_PilotPreviewConfirmPage_SafePassControl",
                        IntroHeaderRDN = "RDN_SafePass",
                        IntroFooterRDN = "RDN_SafePassSectionIntro",
                        EntryHeaderRDN = "RDN_SafePass",
                        EntryMidRDN = "RDN_SafePass",
                        EntryFooterRDN = "RDN_SafePassSectionIntro",
                        CurrentRUN = "RUN_Equities_OrderPreview",
                        IsIntroHeaderContentParamsBased = true,
                        IsIntroFooterContentParamsBased = true,
                        IsEntryHeaderContentParamsBased = true,
                        IsEntryFooterContentParamsBased = true,
                        IsEntryMidContentParamsBased = true,
                        CurrentMode = 9
                    }
                }
            });
        }

        public void Dispose()
        {
            driverService?.Dispose();
        }
    }
}
