
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Threading;

namespace SeleniumConcepts
{
    class Demo1
    {
        static void Main1(string[] args)
        {
            //install driver for firefox --> geckodriver
            IWebDriver driver = new ChromeDriver(); //example of runtime ploymorphism 
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);


            driver.Url = "https://opensource-demo.orangehrmlive.com/index.php/dashboard"; //set //wait for page load to complete

            driver.FindElement(By.Id("txtUsername")).SendKeys("Admin"); //500 ms check for the presence
            driver.FindElement(By.Id("txtPassword")).SendKeys("admin123");

            driver.FindElement(By.Id("btnLogin")).Click();

            //wait for new page load // will add later

            //print the title 
            string actualTitle = driver.Title;
            Console.WriteLine(actualTitle);

            //click on Myinfo
            driver.FindElement(By.Id("menu_pim_viewMyDetails")).Click();

            //click on Emergency Contact
            driver.FindElement(By.LinkText("Emergency Contacts")).Click();

            driver.FindElement(By.Id("welcome")).Click();

            //Thread.Sleep(20000); 

            //logout
            driver.FindElement(By.LinkText("Logout")).Click();


       
        }
    }
}
