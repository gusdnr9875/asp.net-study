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
        // 12. 클래스
        /*
         * 메서드, 속성, 필드, 이벤트 4가지 요소로 구성되어 있다.
         * 이벤트는 어떤 일이 일어났다는 이벤트를 외부로 전달하는데 이용된다.
         * 접근제한자 따라 외부 객체로부터 접근이 허용될 수도 있고 제한될 수도 있다.
         * 속성은 클래스의 내부 데이터를 외부에서 사용할 수 있게 하거나 외부에서 클래스 내부의 데이터를 간단하게 설정할 때 사용한다.
         * Partial 클래스는 하나의 클래스를 2개 이사으이 파일에 나누어 정의할 수 있는 기능이다.
         * 특이한게 클래스안에 클래스를 넣고 사용할 수도 있네
         */
        
        public class MyCustomer
        {
            //필드
            private string name;
            private int age;
            
            //이벤트
            public event EventHandler NameChanged;
            
            //생성자
            public MyCustomer()
            {
                name = string.Empty;
                age = -1;
            }
            
            //속성
            public string Name
            {
                get { return this.name; }
                set
                {
                    if (this.name != value)
                    {
                        this.name = value;
                        if(NameChanged != null)
                            NameChanged(this,EventArgs.Empty);
                    }
                }
            }

            public int Age
            {
                get { return this.age; }
                set { this.age = value; }
            }
            
            // 메서드
            public string GetCustomerDate()
            {
                string data = string.Format("Name: {0} (Age: {1})", this.Name, this.Age);
                return data;
            }

        }
        
        
        static void Main(string[] args)
        {
            MyCustomer obj = new MyCustomer();
            Console.WriteLine(obj.GetCustomerDate());
            obj.Age = 100;
            obj.Name = "hyun wook";
            Console.WriteLine(obj.GetCustomerDate());
        }
    }



}
