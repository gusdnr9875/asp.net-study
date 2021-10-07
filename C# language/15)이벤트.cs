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
        // 15. 이벤트
        /*
         * 이벤트는 클래스내에 특정한 일이 일어났음을 외부의 이벤트 가입자들에게 알려주는 기능을 한다.
         * event 키워드를 사용하여 표시하고 일종의 필드처럼 정의된다.
         * += 연산자를 사용하여 이벤트 핸들러를 이벤트에 추가한다.
         * -= 연산자를 사용해 이벤트 핸들러를 삭제할 수도 있다.
         * 이벤트 핸들러는 이벤트 발생시 어떤 명령을 실행할지 지정하는 것이다.
         * 클래스의 속성에서 get, set을 사용하듯이 event에서는 add, remove 를 사용할 수 있다.
         */


        class MyButton
        {
            public string text;
            public event EventHandler _Click; // 이벤트 핸들러 생성
            
            pulbic

            private event EventHandler Click
            {
                add
                {
                    _Click += value;
                }
                remove
                {
                    _Click -= value;
                }
            }
            
            pulbic void MouseButtonDown()
            {
                if(this.Click != null)
                    Click(this, EventArgs.Empty);
            }
        }
        
        static void Main(string[] args)
        {
            MyButton btn = new MyButton();
            // 클릭 이벤트에 대한 이벤트 핸들러로 btn_click 이라는 메소드를 지정함
            btn.Click += new EventHandler(btn_Click);
            btn.text = "Run";

        }

        void btn_Click(object sender, EventArgs e)
        {
            Console.WriteLine(1);
        }
    }



}
