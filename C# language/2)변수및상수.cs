using System;

namespace ConsoleApp1
{
    class Program
    { 
        // 2. 변수 및 상수
        /*
         * 다른 언어들과 마찬가지로 전역변수와 지역변수 개념이 존재한다. 
         * 클래스에서 선언한 변수는 전역변수로서 객체가 소멸하기전까지 데이터가 보관되어 진다.
         * 상수형도 동일하게 const 키워드를 사용하여 생성한다.
         */
        
        static int globalVar;
        const int MAX = 1024; // const형 변수명을 대문자로 지정하는 것은 개발자간의 약속같은 것. 
        
        static void Main(string[] args)
        {
            //로컬변수
            int localVar;
            
            //아래 할당이 없으면 에러발생
            localVar = 100;
            
            Console.WriteLine(globalVar); //전역변수 사용 아무 값도 입력하지 않으면 0이 자동으로 대입 
            Console.WriteLine(localVar); // 지역변수 사용 
            
            CSVar obj = new CSVar(); // 객체 생성
            obj.method1(); //객체안에 메소드 호출 
            
        }

    
    }

    class CSVar
    {
        public void method1()
        {
            Console.WriteLine("This is method1");
        }
    }


}
