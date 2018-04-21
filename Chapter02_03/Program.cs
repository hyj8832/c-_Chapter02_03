using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter02_03
{
    class Program
    {
        static void Main(string[] args)
        {
            CPartialClass tmpPC = new CPartialClass();
            Console.WriteLine(tmpPC.theModule1);//3
            Console.WriteLine(tmpPC.theModule2);//5
            Console.WriteLine(tmpPC.FunctionA());//1
            Console.WriteLine(tmpPC.FunctionB());//2

            CVector2 tmpV2 = new CVector2();
            tmpV2.x = 3; //set으로 간다.
            Console.WriteLine(tmpV2.x);//setX

            tmpV2.y = 7;
            Console.WriteLine(tmpV2.y);//GetX
            Console.WriteLine(tmpV2.theY);//y와는 전혀 관계 없는거야. 

            var tmpStudent = new { Number=1,Name = "Yiju"}; //var:자료형이 없다.. (동적 바인딩)
            Console.WriteLine(tmpStudent.Number);
            Console.WriteLine(tmpStudent.Name);


        }
    }
    partial class CPartialClass
    {
        public int theModule2;
        public CPartialClass()
        {
            theModule1 = 3;
            theModule2 = 5;
        }

        public int FunctionB()
        {
            return 2;
        }
      
    }
}
