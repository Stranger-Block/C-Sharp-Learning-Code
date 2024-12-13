using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_Sharp_Learning_Code._11_Abstract_Class_And_Abstract_Method.Model;

namespace C_Sharp_Learning_Code._11_Abstract_Class_And_Abstract_Method
{
    public class Abstract_Class_And_Abstract_Method
    {
        public void Abstract_Class_And_Abstract_Method_Method()
        {
            Studenet_Data_print();
            Teacher_Data_print();
        }

        public void Studenet_Data_print()
        {
            Student_Model student_Model = new Student_Model();
            student_Model.Id = 1;
            student_Model.Name = "Smit";
            student_Model.Age = "12";
            student_Model.Roll_Number = "200390107029";
            student_Model.Print_Data();
        }

        public void Teacher_Data_print()
        {
            Teacher_Model teacher_Model = new Teacher_Model();
            teacher_Model.Id = 25;
            teacher_Model.Name = "Rajesh";
            teacher_Model.Age = "45";
            teacher_Model.Salary = "20,000";
            teacher_Model.Print_Data();
        }
    }
}
