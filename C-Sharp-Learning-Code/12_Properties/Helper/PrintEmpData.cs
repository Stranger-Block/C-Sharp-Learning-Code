using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_Sharp_Learning_Code._12_Properties.Model;

namespace C_Sharp_Learning_Code._12_Properties.Helper
{
    public static class PrintEmpData
    {
        public static void PrintEmpData_Method(Emp_Model_Class data)
        {
            Console.WriteLine(data.Id);
            Console.WriteLine(data.Name);
            Console.WriteLine(data.RollNumber);
            Console.WriteLine(data.FatherName);
        }
    }
}
