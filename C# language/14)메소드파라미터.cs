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
        // 14. 메소드
        /*
         * 메소드 앞에는 접근제한자를 적는다.
         * c++과 같이 call by value와 call by reference가 존재한다.
         * 다만 포인터가 있는것은 아니고 ref 키워드를 통해서 기존 값이 변하도록 하는 구조이다.
         * named 파라미터: c# 4.0부터 위치와 상관없이 파라미터명을 지정하여 파라미터를 전달할 수 있게 되었다. 
         * Optional 파라미터: c# 4.0부터 메서드의 파라미터가 디폴트 값을 갖고 있다면 파라미터 생략을 허용했다. 
         */

        static private void Calculate(int a)
        {
            a *= 2;
        }
        static private void Calculate2(ref int a)
        {
            a *= 2;
        }
        static private void Calculate3(int a = 10)
        {
            a *= 2;
        }
        static private void Calculate4(params int [] a)
        {
            
        }
        
        static void Main(string[] args)
        {
            int val = 1;
            Calculate(val);
            Console.WriteLine(val);
            Calculate2(ref val); // 이것 처럼 ref 키워드도 함께 전달해야 하는 것을 주의하자
            Console.WriteLine(val);
            
            //optional 파라미터 사용
            Calculate3();
            
            //params를 통해서 가변 파라미터 갯수를 지정할 수 있다.
            Calculate4(1,2,3,4);
            Calculate4(1,2,3,4,5,6);
            
        }
    }



}
