
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.ObjectModel;
using System.Threading;

namespace SeleniumConcepts
{
    class Demo12
    {
        static void Main12(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            driver.Url = "https://www.goto.com/meeting/trial";

            driver.FindElement(By.Id("truste-consent-button")).Click();

            driver.FindElement(By.Id("login__email")).SendKeys("hello@gmail.com");

            driver.FindElement(By.XPath("//input[@value='10 - 99']")).Click();

            driver.FindElement(By.XPath("//button[text()='Start My Trial']")).Click();

            string errorText=driver.FindElement(By.XPath("//div[@class='inputField__requirements']")).Text;
            Console.WriteLine(errorText);
        }
    }
}
