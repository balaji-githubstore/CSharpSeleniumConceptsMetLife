
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
    class Demo9
    {
        static void Main9(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            driver.Url = "http://demo.openemr.io/b/openemr/interface/login/login.php?site=default";

            driver.FindElement(By.Id("authUser")).SendKeys("admin");
            driver.FindElement(By.Id("clearPass")).SendKeys("pass");

            SelectElement selectLanguage = new SelectElement(driver.FindElement(By.Name("languageChoice")));
            selectLanguage.SelectByText("English (Indian)");

            //button[@type='submit']
            //button[contains(text(),'Login')]
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();

            //wait condition for page load or any element present in new page
            //print title 
            Console.WriteLine(driver.Title);

            Actions action = new Actions(driver);
            action.MoveToElement(driver.FindElement(By.XPath("//span[text()='Billy']"))).Perform();
            
            //click on logout
            driver.FindElement(By.XPath("//li[text()='Logout']")).Click();

            //driver.FindElement(By.Id("form_DOB")).SendKeys("2021-09-02");
   
        
        }
    }
}
