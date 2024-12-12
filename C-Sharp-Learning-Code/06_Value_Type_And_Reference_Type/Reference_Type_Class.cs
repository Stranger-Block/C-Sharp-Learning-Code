using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Learning_Code._06_Value_Type_And_Reference_Type
{
    public class Reference_Type_Class
    {
        // Reference type
        // store in Heap Memory
        public int Salaray;
        public int Age;

        public void GetDetails()
        {
            Reference_Type_Class data = new Reference_Type_Class();

            data.Salaray = 1000;
            data.Age = 45;

            Console.WriteLine("\nPrint Data Before Change");
            printDetails1(data);

            Console.WriteLine("\nPrint Data1 Before Change");
            Reference_Type_Class data1 = data;
            printDetails1(data1);

            Console.WriteLine("\nPrint Data2 Before Change");
            Reference_Type_Class data2 = data;
            printDetails1(data2);

            Console.WriteLine("\nPrint Data After Change");
            data.Salaray = 5000;
            printDetails1(data);

            Console.WriteLine("\nPrint Data1 After Change");
            printDetails1(data1);

            Console.WriteLine("\nPrint Data2 After Change");
            printDetails1(data2);
        }

        public void printDetails1(Reference_Type_Class data)
        {
            Console.WriteLine(data.Salaray);
            Console.WriteLine(data.Age);
        }
    }
}
