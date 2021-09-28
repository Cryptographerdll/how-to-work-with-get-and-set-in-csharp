using System;

namespace Encapsulation_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.ID = 111 ;
            emp1.Nom = "khalil";
            emp1.Salary = 2000;

            emp1.PrintData();
        }
    }
}
