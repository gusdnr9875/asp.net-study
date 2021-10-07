using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ConsoleApp1
{
    /*
    public class MyList
    {
        private int[] data = {1, 2, 3, 4, 5};
        
        private IEnumerator GetEnumerator()
        {
            int i = 0;
            while (i < data.Length)
            {
                yield return data[i];
                i++;
            }
        }
    }
    */
    class Program
    { 
        // 7. yield문
        /*
         * 호출자에게 컬렉션 데이터를 하나씩 리턴할 때 사용한다.
         * iterator(enumerator)기능이다.
         * 즉, 집합적인 데이터셋으로부터 데이터를 하나씩 호출자에게 보내주는 역할
         * return은 하나씩 리턴하는데 사용하고 break는 리턴을 중지하고 Iteration 루프를 빠져 나올 때 사용
         * 필요할 때 추가적으로 더 공부를 해야할 듯.. 지금 봐도 분명 까먹을듯..
         */

        static IEnumerable<int> GetNumber()
        {
            yield return 10; // 첫번째 루프에서 리턴되는 값
            yield return 20; // 두번째 루프에서 리턴되는 값
            yield return 30; // 세번째 루프에서 리턴되는 값
        }
        static void Main(string[] args)
        {
            foreach (int num in GetNumber())
            {
                Console.WriteLine(num);
            }
            
            // 수동 iteration]
            /*
            IEnumerator it = list.GetEnumerator(0);
            it.MoveNext();
            Console.WriteLine(it.Current);
            it.MoveNext();
            Console.WriteLine(it.Current);
            */
        }
    }



}
