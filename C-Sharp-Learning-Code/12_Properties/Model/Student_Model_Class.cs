using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Learning_Code._12_Properties.Model
{
    public class Student_Model_Class
    {
        private int _id;
        private string? _name;
        private int _age;

        private string School_Name = "XYZ School Model";
        private string? School_Address;

        // Read And Write ProPerties
        public int Student_Id
        {
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Please Enter Valid Number");
                }
                else
                {
                    this._id = value;
                }
            }
            get
            {
                return this._id;
            }
        }

        public string Student_Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Enter Valid Data");
                }
                else
                {
                    this._name = value;
                }
            }
            get
            {
                return this._name;
            }
        }

        public int Student_Age
        {
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Enter Valid Data");
                }
                else
                {
                    this._age = value;
                }
            }
            get
            {
                return this._age;
            }
        }

        // Read Only ProPerties
        public string Student_School_Name
        {
            get
            {
                return this.School_Name;
            }
        }

        // Write Only ProPerties
        public string Student_School_Address_Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Enter Valid Data");
                }
                else
                {
                    this.School_Address = value;
                }
            }
        }
    }
}
