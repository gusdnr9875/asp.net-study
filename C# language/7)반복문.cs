using System;
using System.Diagnostics;
using System.Text;

namespace ConsoleApp1
{
    class Program
    { 
        // 6. 조건문
        /*
         * 일반적인 c c++과 동일하다.
         */

        static void Main(string[] args)
        {

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Loop {0}", i);
            }

            string[] array = new string[] {"AB", "CD", "EF"};

            // for가 성능이 좋다는 것도 옛말 거의 동일한 성능이므로 더 간결한 foreach 사용을 권장한다고 한다.
            foreach (string s in array)
            {
                Console.WriteLine(s);
            }
            // 3차원 배열 선언
            string[,,] arr = new string[,,]
            {
                {{"1", "2"}, {"11", "22"}},
                {{"3", "4"}, {"33", "44"}}
            };
            
            for(int i=0;i<arr.GetLength(0);i++) // 이런식으로 배열의 원소 개수를 가져온다.
                for(int j=0;j<arr.GetLength(1);j++)
                    for(int k =0;k<arr.GetLength(2);k++)
                        Console.WriteLine(arr[i,j,k]); // 이런 부분이 다르네
            
            //foreach문으로 한번에 3차원 배열 모두 처리 가능
            foreach(var s in arr)
            {
                Debug.WriteLine(s);
            }

            int temp = 1;
            while (temp <= 10)
            {
                Console.WriteLine(temp);
                temp++;
            }

            temp = 1;
            do
            {
                Console.WriteLine(temp);
                temp++;

            } while (temp < 10);


        }
    }



}
