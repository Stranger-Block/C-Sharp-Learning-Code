using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Learning_Code._09_Inheritance
{
    public class CreateEmployee
    {
        public static Per_Emp_Model_Class CreateEmployee_Method(int id, string firstName, string lastName, string contactNumber, int salary, int workingHours)
        {
            return new Per_Emp_Model_Class
            {
                Id = id,
                First_Name = firstName,
                Last_Name = lastName,
                ContactNumber = contactNumber,
                Per_Salary = salary,
                Per_Working_Hours = workingHours
            };
        }
    }
}
