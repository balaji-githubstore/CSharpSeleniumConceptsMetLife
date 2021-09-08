
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.ObjectModel;
using System.Threading;

namespace SeleniumConcepts
{
    class Demo7
    {
        static void Main7(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            driver.Url = "https://netbanking.hdfcbank.com/netbanking/IpinResetUsingOTP.htm";

            //click on go
            driver.FindElement(By.XPath("//img[@alt='Go']")).Click();

            IAlert alert= driver.SwitchTo().Alert();

            string alertText= alert.Text;
            Console.WriteLine(alertText);

            Thread.Sleep(2000);
            alert.Accept();
        }
    }
}
