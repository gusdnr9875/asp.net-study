using System;

namespace ConsoleApp1
{
    class Program
    { 
        // 3. 배열
        /*
         * C#에서도 Zero-base 배열이다.
         * 사용하는 방식은 비슷한데, 가변 배열로도 선언할 수 있다.
         * 다차원 배열은 [,] 와 같은 문법으로 작성하는게 특징이다.
         * 
         */
        
        static void Main(string[] args)
        {
            //1차 배열
            string[] player = new string[10]; // 자바와 동일 10개를 저장할 수 있는 배열 생성
            Console.WriteLine(player);
            string[] Regions = {"서울", "경기", "부산"};
            Console.WriteLine(Regions);
            
            //2차 배열
            string[,] Depts = {{"김과장", "경리부"}, {"이과장", "총무부"}}; 
            Console.WriteLine(Depts);
            
            //3차 배열
            string[,,] Cubes ={};
            Console.WriteLine(Cubes);
            
            //가변 배열
            int[][] A = new int[3][]; // 가변 배열인 경우 [][]와 같이 각 차원마다 괄호를 별도로 사용한다. JAVA스타일
            A[0] = new int[2];
            A[1] = new int[3] {1,2,3};
            A[2] = new int[4] {1, 2, 3, 4};

            A[0][0] = 1;
            A[0][1] = 2;
            
            Console.WriteLine(A[0]); // 주소값을 넣게 되면 자료형이 반환이 되고
            Console.WriteLine((A[0][0])); // 값을 넣게 되면 값이 출력되는 형태

            int[] temp = {1, 2, 3};
            Console.WriteLine(calculate(temp)); // 이런식으로 배열을 전달하면서 사용하면 된다. 

        }

        static int calculate(int[] scores) // 매개변수로 배열을 전달받고 사용 가능 
        {
            int sum = 0;
            for (int i = 0; i < scores.Length; i++)
                sum += scores[i];
            return sum;
        }
    
    }



}
