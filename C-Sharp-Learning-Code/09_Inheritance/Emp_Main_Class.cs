using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Learning_Code._09_Inheritance
{
    public class Emp_Main_Class
    {
        public void Emp_Main_Class_Function()
        {
            var smit = CreateEmployee.CreateEmployee_Method(1, "Smit", "Bhanushali", "9099729778", 1000, 10);
            var rohan = CreateEmployee.CreateEmployee_Method(2, "Rohan", "Patel", "4099729779", 2000, 12);

            PrintAllDetail.PrintAllDetail_Method(smit);
            PrintAllDetail.PrintAllDetail_Method(rohan);

            Console.WriteLine(Emp_Model_Class.Age);
            Console.WriteLine(Per_Emp_Model_Class.Age);
        }
    }
}
