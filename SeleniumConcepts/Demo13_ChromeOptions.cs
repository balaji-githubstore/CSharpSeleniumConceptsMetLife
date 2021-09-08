
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;

namespace SeleniumConcepts
{
    class Demo13
    {
        static void Maine(string[] args)
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--disable-notifications");
            //options.AddArguments("start-maximized");
            //options.AcceptInsecureCertificates = true;
            //options.BinaryLocation = @"C:\Program Files\Google\Chrome\Application\chrome.exe";

            options.AddUserProfilePreference("download.default_directory", "D:\\");

            IWebDriver driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = "https://www.medplusmart.com/";

        }
    }
}
