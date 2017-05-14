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

        private readonly CookieContainer cookies = new CookieContainer();

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

            // store cookies
            foreach (OpenQA.Selenium.Cookie c in driver.Manage().Cookies.AllCookies)
            {
                string name = c.Name;
                string value = c.Value;
                cookies.Add(new System.Net.Cookie(name, value, c.Path, c.Domain));
            }

            pageId = driver.FindElementById("__PageIdField").GetAttribute("value");
            driverService.Dispose();
        }

        public GetQuoteResp TestGetData()
        {
            GetQuoteReq req = new GetQuoteReq
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
            };

            Uri referer = new Uri("https://olui2.fs.ml.com/TFPSummary/PortfolioSimpleView.aspx");
            return req.GetResponse(userAgent, referer, cookies, pageId);
        }

        public SubmitOrderResp TestBuy()
        {
            SubmitOrderReq req = new SubmitOrderReq
            {
                Data = new EquityTradeTicketDisc
                {
                    EquityTradeTicket = new EquityTradeTicket
                    {
                        ActionType = EquityTradeTicketDisc.ActionType.Buy,
                        SymbolId = "TSLA",
                        Quantity = 1,
                        AccountIdentifier = new AccountIdentifier
                        {
                            Type = "Account",
                            Index = 1
                        },
                        Price = 100,
                        Duration = EquityTradeTicketDisc.Duration.Day,
                        OrderType = EquityTradeTicketDisc.OrderType.Limit,
                        TLTData = "{\"TaxLotInput\":{\"AccountIndex\":-1,\"Action\":\"\",\"SecurityNumber\":\"\",\"ProductClassCode\":\"\",\"Symbol\":\"\",\"SpecifiedShares\":0,\"TradingSessionEnum\":0},\"Quantity\":0,\"UserSelectionData\":null,\"IsUserDataEntered\":false,\"UserSortedColumn\":\"\",\"UserSortedOrderAsec\":false}"
                    },
                    Disclaimers = "D439,D440,D450,D351,D955,D1083,D567",
                    SafePassRequest = new SafePassRequest
                    {
                        SafePassFunction = "Trading",
                        CurrentApplication = 1,
                        ShowSafePassIntroPanel = true,
                        ShowSafePassEntryPanel = true,
                        SafePassControlClientId = "ctl00_ctl00_ctl00_cphSiteMst_cphNestedPage_cphStage_view1_PilotPreviewConfirmPage_SafePassControl",
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
                    },
                    ReAuthPassword = string.Empty
                }
            };

            Uri referer = new Uri("https://olui2.fs.ml.com/TFPSummary/PortfolioSimpleView.aspx");
            return req.GetResponse(userAgent, referer, cookies, pageId);
        }
    }
}
