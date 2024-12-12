using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Learning_Code._09_Inheritance
{
    public class PrintAllDetail
    {
        public static void PrintAllDetail_Method(Per_Emp_Model_Class data1)
        {
            Console.WriteLine(data1.Id);
            Console.WriteLine(data1.First_Name);
            Console.WriteLine(data1.Last_Name);
            Full_Name_Detail.Full_Name(data1.First_Name, data1.Last_Name);
            Console.WriteLine(data1.ContactNumber);
            Console.WriteLine(data1.Per_Salary);
            Console.WriteLine(data1.Per_Working_Hours);
        }
    }
}
