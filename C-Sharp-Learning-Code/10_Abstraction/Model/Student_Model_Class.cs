
using C_Sharp_Learning_Code._10_Abstraction.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C_Sharp_Learning_Code._10_Abstraction.Model
{
    public class Student_Model_Class
    {
        public int Id;
        public string Name;
        public int Income;
        public string Scholarship;
        public double fee;

        public Student_Model_Class(int id, string name, int income)
        {
            this.Id = id;
            this.Name = name;
            this.Income = income;
            Total_Fee.Total_Fee_Method(Id, Name, Income);
        }  
    }   
}
