using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_Sharp_Learning_Code._12_Properties.Model;


namespace C_Sharp_Learning_Code._12_Properties.Helper
{
    public static class PrintData
    {
        public static void PrintData_Method(Student_Model_Class student)
        {
            Console.WriteLine(student.Student_Id);
            Console.WriteLine(student.Student_Name);
            Console.WriteLine(student.Student_Age);
            Console.WriteLine(student.Student_School_Name);
            //Console.WriteLine(student.Student_School_Address_Name);
        }
    }
}
