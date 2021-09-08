
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.ObjectModel;
using System.Threading;

namespace SeleniumConcepts
{
    class Demo5
    {
        static void Main5(string[] args)
        {
            IWebDriver driver = new ChromeDriver(); 
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            driver.Url = "https://www.online.citibank.co.in/";

            driver.FindElement(By.LinkText("APPLY FOR CREDIT CARDS")).Click();

            driver.SwitchTo().Window(driver.WindowHandles[1]);

            //click on travel 
            Console.WriteLine(driver.Title);

            driver.FindElement(By.LinkText("Travel")).Click();

            driver.Close();

            driver.SwitchTo().Window(driver.WindowHandles[0]);
            //print the title
            Console.WriteLine(driver.Title);
        }
    }
}
