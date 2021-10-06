using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1. 데이터 타입
            /*
             * c# 코드에서는 123, true, "ABC"와 같이 값을 직접 써줄 수 있는 값을 리터널이라고 한다.
             * C# 에서는 리터럴 데이터를 사용할 때 별도의 접미어 표시를 해주는데 없다면, 자동으로 기본값이 할당되는 구조이다.
             */
            bool b = true;
            Console.WriteLine(b);

            short sh = -32768;
            Console.WriteLine(sh);

            sh = 10000; // 1000000000을 대입해서 오버플로우를 확인하려고 했지만, IDE에서 미리 경고를 띄워준다.
            Console.WriteLine(sh);

            int i = 2000000000; // int는 대입가능
            long l = 1234L; // 접미어 포함 long 형 타입임을 명시
            float f = 123.45F; // float 형 타입임을 명시
            double d1 = 123.45;
            double d2 = 123.45D;
            decimal d = 123.45M;

            char c = 'A';
            string s = "hello";

            DateTime dt = new DateTime(2011, 10, 30, 12, 35, 0);

            Console.WriteLine(dt);
            Console.WriteLine(d1  + d2);
            s = null;
            Console.WriteLine(s);


        }
    }
}
