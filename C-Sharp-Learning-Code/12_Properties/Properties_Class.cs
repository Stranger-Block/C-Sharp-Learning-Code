using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_Sharp_Learning_Code._12_Properties.Helper;
using C_Sharp_Learning_Code._12_Properties.Model;


namespace C_Sharp_Learning_Code._12_Properties
{
    public class Properties_Class
    {
        public void Properties_Class_Method()
        {
            Properties_Class_Property_Type1();
            Properties_Class_Property_Type2();
        }

        public void Properties_Class_Property_Type1()
        {
            Student_Model_Class student_Model_Class = new Student_Model_Class();
            student_Model_Class.Student_Id = 1;
            student_Model_Class.Student_Name = "Smit";
            student_Model_Class.Student_Age = 30;
            //student_Model_Class.Student_School_Name = "XYZ";
            PrintData.PrintData_Method(student_Model_Class);
        }

        public void Properties_Class_Property_Type2()
        {
            Emp_Model_Class emp_Model_Class_Emp = new Emp_Model_Class();
            emp_Model_Class_Emp.Id = 2;
            emp_Model_Class_Emp.Name = "Rohan Patel";
            //emp_Model_Class_Emp.RollNumber = 2;
            //emp_Model_Class_Emp.FatherName = "Rohan Patel";

            PrintEmpData.PrintEmpData_Method(emp_Model_Class_Emp);
        }




    }
}
