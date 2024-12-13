using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Learning_Code._09_Inheritance
{
    public class Temp_Emp_Model_Class : Emp_Model_Class
    {
        int Temp_Salary;
        int Temp_Working_Hours;

        public void PrintData()
        {
            Console.WriteLine(this.Temp_Salary);
            Console.WriteLine(this.Temp_Working_Hours);
        }
    }

    
}
