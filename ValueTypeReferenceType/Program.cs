using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypeReferenceType
{
    class Student
    {
        public string StudentName{ get; set; }
    }
    class Program
    {
        static void ChangeValue(int x)
        {
            x = 200;

            Console.WriteLine(x);
        }

        static void ChangeReferenceType(Student std2)
        {
            std2.StudentName = "Steve";

            Console.WriteLine(std2.StudentName);
        }

        static void Main(string[] args)
        {
            //for value type
            int i = 100;

            Console.WriteLine(i);

            ChangeValue(i);

            Console.WriteLine(i);

            Student std1 = new Student();
            std1.StudentName = "Bill";

            Console.WriteLine(std1.StudentName);

            ChangeReferenceType(std1);

            Console.WriteLine(std1.StudentName);
            Console.ReadKey();
        }
    }
}
