using System;
using System.Collections.Generic;
using System.Text;

namespace MetLife.CSharp123
{
    class Calculator
    {
        public static int aS = 20;
        public int bS = 20;

        private int _age;

        public Calculator()
        {
           
        }

        public Calculator(int a, String b)
        {
            bS = a;
            Console.WriteLine(a);
        }
        public Calculator(int a, int b)
        {
            
        }
        public Calculator(string a, int b)
        {

        }
        public Calculator(int a,String b,int c)
        {
            bS = a;
            Console.WriteLine(a);
        }

        public int Age
        {
            get
            {
                return _age;
            }

            set
            {
                if(value>0)
                 this._age = value;
                else
                    Console.WriteLine("not valid");
            }
        }

        
        public double Sub(int a, int b)
        {
            return a - b;
        }
        public static void Add(int a, int b)
        {
            Console.WriteLine(a);
        }
        //areaOfTriangle
        //areaOfRectangle
        //areaOfSquare
    }
}
