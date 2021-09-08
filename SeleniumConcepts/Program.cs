
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
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            driver.Url = "https://www.medibuddy.in/";

            if(driver.FindElements(By.Id("wzrk-cancel")).Count>0) //check presence
            {
                if(driver.FindElement(By.Id("wzrk-cancel")).Displayed) //check visiblity
                {
                    driver.FindElement(By.Id("wzrk-cancel")).Click();
                }
            }

            driver.FindElement(By.LinkText("Signup")).Click();

            driver.FindElement(By.Id("mobile")).SendKeys("123");
            driver.FindElement(By.Id("name")).SendKeys("hello123");
            driver.FindElement(By.Id("email")).SendKeys("hello@gmail.com");
            driver.FindElement(By.XPath("//button[text()='Sign up']")).Click();

            string text = driver.FindElement(By.XPath("//div[contains(text(),'INVALID')]")).Text;

            Console.WriteLine(text);
            
        }
    }
}
