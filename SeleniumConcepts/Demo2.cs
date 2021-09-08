
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace SeleniumConcepts
{
    class Demo2
    {
        static void Main2(string[] args)
        {
            IWebDriver driver = new ChromeDriver(); 
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            driver.Url = "https://magento.com";

            driver.FindElement(By.XPath("//span[text()='Sign in']")).Click();
            driver.FindElement(By.LinkText("Create an account")).Click();
            driver.FindElement(By.Id("firstname")).SendKeys("Balaji");
            driver.FindElement(By.Id("lastname")).SendKeys("Dinakaran");

            SelectElement selectCompany = new SelectElement(driver.FindElement(By.Id("company_type")));
            selectCompany.SelectByText("Tech Partner");

            SelectElement selectCountry = new SelectElement(driver.FindElement(By.Id("country")));
            selectCountry.SelectByText("India");


            //select country as india
            
            Thread.Sleep(5000);
            driver.Quit();
        }
    }
}
