
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.ObjectModel;
using System.Threading;

namespace SeleniumConcepts
{
    class Demo4
    {
        static void Main4(string[] args)
        {
            IWebDriver driver = new ChromeDriver(); 
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            driver.Url = "https://www.online.citibank.co.in/";


            driver.FindElement(By.LinkText("APPLY FOR CREDIT CARDS")).Click();

            Thread.Sleep(5000);

            string parent= driver.CurrentWindowHandle;
            Console.WriteLine(parent);
            Console.WriteLine("---------------------------------------");

            ReadOnlyCollection<string> windows= driver.WindowHandles;
            Console.WriteLine(windows[0]);
            Console.WriteLine(windows[1]);


            driver.SwitchTo().Window(windows[1]);

            //click on travel 
            Console.WriteLine(driver.Title);

            driver.FindElement(By.LinkText("Travel")).Click();

            driver.Close();

            driver.SwitchTo().Window(parent);
        }
    }
}
