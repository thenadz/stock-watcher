﻿using System;
using System.Net;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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

        public void TestGetData()
        {
            StockDataReq req = new StockDataReq
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
            StockDataResp data = req.GetResponse(userAgent, referer, cookies, pageId);
        }

        public void TestBuy()
        {
            // TODO
        }
    }
}