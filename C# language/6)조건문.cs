using System;
using System.Text;

namespace ConsoleApp1
{
    class Program
    { 
        // 6. 조건문
        /*
         * 일반적인 c++문법과 동일하다.
         * 가볍게 넘어가자.
         */

        static void Main(string[] args)
        {

            int a = -11;
            int val;
            if (a >= 0)
                val = a;
            else
                val = -a;
            Console.WriteLine(val);

            string category = "딸기";
            int price = 0;
            switch (category)
            {
                case "사과":
                    price = 100;
                    break;
                case "포도":
                    price = 10;
                    break;
                default:
                    price = 5;
                    break;
            }
            Console.WriteLine(price);

            
            



        }
    }



}
