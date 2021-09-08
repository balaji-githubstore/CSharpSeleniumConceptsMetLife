
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.ObjectModel;
using System.Threading;

namespace SeleniumConcepts
{
    class Demo6
    {
        static void Main6(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            driver.Url = "https://www.online.citibank.co.in/";

            driver.FindElement(By.LinkText("APPLY FOR CREDIT CARDS")).Click();
            driver.FindElement(By.XPath("//span[text()='Login']")).Click();


            //ReadOnlyCollection<string> windows = driver.WindowHandles;

            //foreach (string win in windows)
            //{
            //    Console.WriteLine(win);
            //    driver.SwitchTo().Window(win);
            //    Console.WriteLine(driver.Title);
            //    Console.WriteLine(driver.Url);
            //    Console.WriteLine("--------------------------");
            //    if (driver.Title.Equals("Citibank India"))
            //    {
            //        break;
            //    }
            //}

            //Console.WriteLine(driver.Title);
            //driver.Close();

            ReadOnlyCollection<string> windows = driver.WindowHandles;
            foreach (string win in windows)
            {
                driver.SwitchTo().Window(win);
                if (driver.Title.Equals("Citibank India"))
                {
                    break;
                }
            }

            //will start by 3:50 PM IST
            driver.Close();
        }
    }
}
