using System;
using System.Text;

namespace ConsoleApp1
{
    class Program
    { 
        // 4. 문자열
        /*
         * 문자열을 사용하는 방식은 다른 언어들과 유사하다.
         * 큰 특징은 없고 직접 타이핑해보면서 조금씩 다른 문법들에 익숙해지는데 집중하면서 작성하였다.
         * 인덱스로 문자열 값을 참조할 수 있다.
         * mutable 타입인 StringBuilder 클래스는 문자열 갱신이 많은 곳에서 자주 사용된다.
         * 이 클래스는 별도 메모리를 생성, 소멸하지 않고 일정한 버퍼를 갖고 문자열 개신을 효율적으로 처리한다.
         */

        static void Main(string[] args)
        {
            // 문자열(string) 변수
            string s1 = "C#";
            string s2 = "Programming";
            
            // 문자(char) 변수
            char c1 = 'A';
            char c2 = 'B';
            string temp = "" + c1 + c2;
            Console.WriteLine(temp);
            
            // 문자열 결합
            string s3 = s1 + " " + ' ' + s2;
            
            // 부분 문자열 발췌
            string s3substring = s3.Substring(1, 5);
            Console.WriteLine("totalstirng : {0}",s3);
            Console.WriteLine("Substrubg: {0}",s3substring);
            
            
            string s = "C# Studies";

            // 문자열을 배열인덱스로 한문자 엑세스
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine("{0}: {1}", i, s[i]);
            }
            
            // 문자열을 문자배열로 변환
            string str = "Hello";
            char[] charArray = str.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                Console.WriteLine(charArray[i]);
            }
            
            // 문자배열을 문자열로 변환
            char[] charArray2 = {'A', 'B', 'C', 'D'};
            s = new string(charArray2); 
            Console.WriteLine(s);
            
            // 문자 연산
            char cc1 = 'A';
            char cc2 = (char) (cc1 + 3); // 아스킷 값을 사용하게 되어서 D가 출력되는 구조
            Console.WriteLine(cc2);
            
            // StringBuilder 클래스
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= 26; i++)
            {
                sb.Append(i.ToString());
                sb.Append(System.Environment.NewLine);
            }

            string ss = sb.ToString();
            
            Console.WriteLine(ss);

            
            

        }
    }



}
