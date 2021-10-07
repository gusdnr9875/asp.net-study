using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ConsoleApp1
{
 
    class Program
    { 
        // 9. 예외처리문
        /*
         * 자바와 동일한 문법
         * 타이핑 치면서 익숙하게끔 학습
         */

        public int DoSomething()
        {
            return 0 * 0; // division by zero error
        }
        static void Main(string[] args)
        {
            try
            {
                //int num = DoSomething();
            }
            catch (Exception ex) // 매개변수에는 어떤 예외처리를 처리할지 
            {
                //Log(ex);
                //throw;
            }
            finally //throw가 있으면 에러는 던저누느 것 이다. 주로 메소드 내에서 메시지를 던질 때 사용한다. 
            {
                // 마지막으로 실행하는 문장들 
            }
            
        }
    }



}
