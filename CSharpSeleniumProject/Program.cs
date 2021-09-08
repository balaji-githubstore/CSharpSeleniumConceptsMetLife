using MetLife.CalculatorProject123;
using MetLife.CSharp123;
using System;
using System.Collections.Generic;

namespace MetLife.CSharpSeleniumProject
{

    interface IWebDriver1
    {
        void Close();
        void Quit();
        //String Url { get; set; }
    }

    class ChromeDriver1 : IWebDriver1
    {
        public void ChromeOnly()
        {

        }

        public void Close()
        {
           //close chrome tab
        }

        public void Quit()
        {
            Console.WriteLine("quit the chrome browser");
        }
    }

    class FirefoxDriver1 : IWebDriver1
    {
        public void Close()
        {
            //close firefox tab
        }

        public void Quit()
        {
            //
        }
    }

    class Program 
    {
        static void Main(string[] args)
        {
            CalculatorDemo.add(4, 4,4);
            List<string> colors = new List<string>();
            colors.Add("red");
            colors.Add("yellow");
            colors.Add("green");
            colors.Add("jellkj");


            Dictionary<int, string> keyValues = new Dictionary<int, string>();

            keyValues.Add(101, "john");
            keyValues.Add(102, "peter");

            keyValues.Add(103, "mark");
            //keyValues.Add(102, "peter223");

            Console.WriteLine(keyValues[101]);
            Console.WriteLine(keyValues[101]);


            Calculator.aS = 465;
            Console.WriteLine(Calculator.aS);

            Calculator cal = new Calculator(45,"");
            cal.bS = 450;

            cal.Age = -45;

            int age = cal.Age;
            Console.WriteLine(age);

            Console.WriteLine(cal.Age);

            Console.WriteLine(cal.bS);
           
            //Console.wr

            //Console.WriteLine(cal.age);

            //IWebDriver1 driver =new ChromeDriver1();
            //driver.Close();
            //driver.Quit();



            //CalculatorDemo.add(45, 45);
            //Calculator.Add(45, 45);
            //Calculator obj = new Calculator();
            //double ans= obj.Sub(5,1);

            //Console.WriteLine("balaji 123");
            //Console.ReadLine();
        }
    }
}
