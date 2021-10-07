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
        // 12-2. 클래스 상속
        /*
         * 다른언어들과 동일하게 추상클래스, 인터페이스의 개념을 가지고 있다.
         * 추상클래스는 무조건 다른 파생클래스에서 멤버들을 구현시켜주어야 한다.
         * 업캐스팅과 다운캐스팅개념도 존재한다. as 연산자를 사용한다.
         * is 연산자는 앞에 있는 객테가 특정 클래스 타입이나 인터페이스를 갖고 있는지 확인하는데 사용한다.
         * 캐스팅과 관련해서는 추가적인 학습이 필요할 것 같다. 
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

        class inherit : MyCustomer
        {
            public string GetCustomerDate() //메소드 오버라이딩
            {
                string data = string.Format("inherit Name: {0} (Age: {1})", this.Name, this.Age);
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


            inherit inh = new inherit();
            inh.Name = "wook";
            inh.Age = 100;
            Console.WriteLine(inh.GetCustomerDate());
        }
    }



}
