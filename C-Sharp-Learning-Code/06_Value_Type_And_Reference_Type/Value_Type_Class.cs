using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Learning_Code._06_Value_Type_And_Reference_Type
{
    public struct Value_Type_Class
    {
        // value type
        // store in Stack Memory
        public int Salaray;
        public int Age;

        public void GetDetails()
        {
            Value_Type_Class data = new Value_Type_Class();

            data.Salaray = 1000;
            data.Age = 45;

            Console.WriteLine("\nPrint Data Before Change");
            printDetails1(data);

            Console.WriteLine("\nPrint Data1 Before Change");
            Value_Type_Class data1 = data;
            printDetails1(data1);

            Console.WriteLine("\nPrint Data2 Before Change");
            Value_Type_Class data2 = data;
            printDetails1(data2);

            Console.WriteLine("\nPrint Data After Change");
            data.Salaray = 5000;
            printDetails1(data);

            Console.WriteLine("\nPrint Data1 After Change");
            printDetails1(data1);

            Console.WriteLine("\nPrint Data2 After Change");
            printDetails1(data2);
        }

        public void printDetails1(Value_Type_Class data)
        {           
            Console.WriteLine(data.Salaray);
            Console.WriteLine(data.Age);
        }
    }


}
