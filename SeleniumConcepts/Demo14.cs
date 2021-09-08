
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
    class Demo14
    {
        static void Main14(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            //driver.Url = "https://www.royalcaribbean.com/account/create";
            driver.Url = "https://www.medibuddy.in/";

            //int count = driver.FindElements(By.XPath("//hello")).Count;

            //Console.WriteLine(count);


            //checks for the present of element
            //if (driver.FindElements(By.XPath("//*[@class='email-capture__close']")).Count > 0)
            //{
            //    //check for visiblity
            //    if(driver.FindElement(By.XPath("//*[@class='email-capture__close']")).Displayed)
            //    {
            //        driver.FindElement(By.XPath("//*[@class='email-capture__close']")).Click();
            //    }
            //}

            //input[@data-placeholder='First name/Given name']

            driver.FindElement(By.XPath("//span[text()='Month']")).Click();
            driver.FindElement(By.XPath("//span[contains(text(),'April')]")).Click();
        }
    }
}
