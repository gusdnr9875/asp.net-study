using System;
using System.Text;

namespace ConsoleApp1
{
    class Program
    { 
        // 5. 연산자
        /*
         * 다른 프로그래밍 언어들과 동일한 구조
         * ?? 연산자는 C# 3.0 이상에서 지원하는 연산자이다.
         * ?? 왼쪽 피연산자의 값이 NULL인 경우 뒤의 피연산자를 리턴하고 아니면 그냥 ?? 앞의 피연산자값만 리턴한다.
         */

        static void Main(string[] args)
        {
            int a = (1 + 2 - 3) * (4 / 5) % 6;
            Console.WriteLine(a);

            int b = 100;
            b += 100;
            Console.WriteLine(b);

            b++;
            Console.WriteLine(b);
            
            // 그 외에 논리, 비트, 조건 연산자 모두 동일
            
            // ?? 연산자 
            int? i = null; // 원래 int는 null을 가질 수 없다. c#에선 0!=null, int? 타입은 허용된다.
            i = i ?? 0;

            string s = null;
            s = s ?? string.Empty;
            Console.WriteLine(i);
            Console.WriteLine(s);
            

        }
    }



}
