using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;

namespace ConsoleApp1
{
 
    class Program
    { 
        // 11. 구조체
        /*
         * struct를 사용하면 Value Type을 만들고 class를 사용하면 Reference Type을 만들 수 있다.
         * 특이한 점은 구조체에도 생성자, 함수가 있다는점
         * 하지만 c# 구조체는 상속을 할 수 없다. 근데 인터페이스는 또 구현이 가능하다고 한다. 
         */


        struct MyStruct
        {
            private int x;
            private int y;

            public MyStruct(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public override string ToString()
            {
                return string.Format("({0}, {1})", x, y);
            }
        }
        static void Main(string[] args)
        {
            //구조체 사용
            MyStruct st = new MyStruct(10, 12);
            Console.WriteLine(st.ToString());
        }
    }



}
