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
        // 13. Nullable 타입
        /*
         * c#에서는 정수, 부동자릿수, 구조체들은 Value Type은 NULL을 가질 수 없다. 0 is not null in c#
         * ?키워드를 사용해서 변수에 null을 할당할 수 있다.
         * 이때 .NET의 Nullable<T> 구조체로 컴파일시 변환된다. 즉, int?는 Nullable<int>와 동일하다.
         */

        private double _Sum = 0;
        private DateTime _Time;
        private bool? _Selected;

        public void CheckInput(int? i, double? d, DateTime? time, bool? selected)
        {
            if (i.HasValue && d.HasValue)
                this._Sum = (double) i.Value + (double) d.Value;
            //time값이 있는지 체크
            if (!time.HasValue)
                throw new ArgumentException();
            else
            {
                this._Time = time.Value;
            }
            // 만약 selected가 NULL이면 false를 할당
            this._Selected = selected ?? false;
        }
        
        static void Main(string[] args)
        {
           // CheckInput(null, null, null, null);
            
           //System.Nullalbe은 2개의 nullalbe 객체를 비교하거나 value타입을 알아내는 기능
           int? a = null;
           int? b = 0;
           int result = Nullable.Compare<int>(a, b);
           
           Console.WriteLine(result);

           double? c = 0.01;
           double? d = 0.0100;
           bool result2 = Nullable.Equals<double>(c, d);
           Console.WriteLine(result2);
        }
    }



}
