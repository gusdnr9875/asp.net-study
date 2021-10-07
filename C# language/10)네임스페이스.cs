using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ConsoleApp1
{
 
    class Program
    { 
        // 10. 네임스페이스
        /*
         * .net 4.0 기준으로는 약 11000개의 클래스를 가지고 있다고 한다. 이렇게 많은 클래스들을 충돌없이 보다 편리하게 관리하기 위해 네임스페이스를 사용한다.
         * 네임스페이스가 없어도 정의될 수 있는 있지만 사용하는것이 일반적이다.
         * using ~~ 로 네임스페이스를 불러온다.
         * ex) System.Console.WriteLine 이지만 using System을 통해 System은 생략이 가능하다.
         */

       
        static void Main(string[] args)
        {
            System.Console.WriteLine(); // 네임 스페이스로 포함하였기 때문에 생략 가능
            Console.WriteLine();
            int sum = System.Math.Abs(10) + Math.Abs(5);
            
            Console.WriteLine(sum);

            // 다른 클래스를 사용할때도 마찬가지 형식으로 포함하고 사용하면 된다. 
        }
    }



}
