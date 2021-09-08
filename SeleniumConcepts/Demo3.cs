
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace SeleniumConcepts
{
    class Demo3
    {
        static void Main3(string[] args)
        {
            IWebDriver driver = new ChromeDriver(); 
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            driver.Url = "https://netbanking.hdfcbank.com/netbanking/";

            //switch into frame 
            driver.SwitchTo().Frame("login_page");

            //driver.SwitchTo().Frame(driver.FindElement(By.XPath("")));

            driver.FindElement(By.Name("fldLoginUserId")).SendKeys("test123");

            driver.FindElement(By.LinkText("CONTINUE")).Click();

            //come out of frame
            driver.SwitchTo().DefaultContent();
        }
    }
}
