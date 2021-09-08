
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
    class Demo11
    {
        static void Main11(string[] args)
        {
            //string value = Console.ReadLine();
            //Console.WriteLine(value);    

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            driver.Url = "https://datatables.net/extensions/select/examples/initialisation/checkbox.html";

            SelectElement select = new SelectElement(driver.FindElement(By.Name("example_length")));
            select.SelectByText("50");

            //int linkCount = driver.FindElements(By.TagName("a")).Count;
            //Console.WriteLine(linkCount);

            int rowCount=driver.FindElements(By.XPath("//table[@id='example']/tbody/tr")).Count;

            for (int i = 1; i <= rowCount; i++)
            {
                string name = driver.FindElement(By.XPath("//table[@id='example']/tbody/tr[" + i + "]/td[2]")).Text;
                Console.WriteLine(name);
            }
            //int a = Convert.ToInt32(value);
            

        }
    }
}
