
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.ObjectModel;
using System.Threading;

namespace SeleniumConcepts
{
    class Demo8
    {
        static void Main8(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            driver.Url = "http://demo.openemr.io/b/openemr/interface/login/login.php?site=default";


            string appDesc = driver.FindElement(By.XPath("//p[contains(text(),'most')]")).Text;
            Console.WriteLine(appDesc);

            // IWebElement ele= driver.FindElement(By.Id("authUser"));

            string href=driver.FindElement(By.PartialLinkText("Licensing")).GetAttribute("href");
            Console.WriteLine(href);

            string attribute= driver.FindElement(By.Id("authUser")).GetAttribute("placeholder");
            Console.WriteLine(attribute);

            driver.FindElement(By.Id("authUser")).SendKeys("admin");
            driver.FindElement(By.Id("clearPass")).SendKeys("admin");
            



            //click on login

            //print title 

            //click on logout


        }
    }
}
