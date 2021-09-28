using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation_2
{
    class Employee
    {
        // Avant Encapsulation :

        private int id;
        private string nom;
        private double salary;

        // L'Encapsulation : 

        public int ID
        {
            get { return id; }
            set { this.id = value; }
        }

        public string Nom
        {
            get { return nom; }
            set { this.nom = value; }
        }

        public double Salary
        {
            get { return salary; }
            set {
                  if (value < 5000)
                    value = 5000;
                  
                     this.salary = value;
                }
        }

        private string MyPrintData()
        {
            return id + ";" + nom + ";" + salary;
        }

        public void PrintData()
        {
            Console.WriteLine(MyPrintData().Replace(";", "-"));
        }
    }
}
