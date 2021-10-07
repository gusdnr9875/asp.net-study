#define TEST_ENV 
#pragma warning disable3021 
// CS3021 Warning을 Disable하겠다는 의미이다. pragma는 컴파일러 제작업체가 고유하게 자신들의 것을 만들어 사용하는 지시어이다. 즉 가져다 쓰기만 하면 된다.
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
        // 16. 전처리기 지시어 
        /*
         * 실제 컴파일이 시작되기 전에 컴파일러에게 특별한 명령을 미리 처리하도록 지시하는것이다.
         * c++에서와 마찬가지로 #으로 시작되며 한라인에 한개의 전처리기 명령만을 사용한다. 세미콜론은 붙이지 않는다.
         * 전처리기 지시어는 해당 파일 안에서만 효력이 발생한다. 만약 partial class인 경우 두개에 파일에 각각 심벌을 정의해야 하낟. 
         */


        
        
        static void Main(string[] args)
        {
            bool verbose = false;
            // TEST_ENV 심벌이 정의되어 있기 때문에 콘솔에 if문내용이 호출되는 구조이다. 
#if (TEST_ENV)            
            Console.WriteLine("Test Environment: Verbose option is set.");
            verbose = true;
#else            
            Console.WriteLine("production");
#endif
            if (verbose)
            {
                Console.WriteLine("verbose is true");
            }

        }

       
    }

    
    // #region 은 코드 블럭을 논리적으로 묶을 때 유용하게 사용한다. 
    class ClassA
    {
        #region Public Methods
        public void Run() {}
        public void Create() {}
        #endregion

        #region Public Properties
        public int Id { get; set; }
        #endregion

        #region  Privates

        private  void Execute() {}

        #endregion
        
    }
    
    /*
     * 기타 전처리기 지서는 다양한 존재한다.
     * #undef 은 지정된 심벌을 해제할 때 사용
     * #error는 전처리시 Preprocessing을 중단하고 에러 메시지를 출력하게 한다.
     * #warning은 경고 메시지를 출력하지만 프로세싱은 계속 진행한다. 
     */

    
}
