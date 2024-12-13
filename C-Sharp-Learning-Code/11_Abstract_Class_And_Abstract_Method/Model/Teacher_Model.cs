﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Learning_Code._11_Abstract_Class_And_Abstract_Method.Model
{
    public class Teacher_Model: Person_Model
    {
        public string? Salary;

        public override void Print_Data()
        {
            Console.WriteLine(Id);
            Console.WriteLine(Name);
            Console.WriteLine(Age);
            Console.WriteLine(Salary);
        }
    }
}
