using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Learning_Code._11_Abstract_Class_And_Abstract_Method.Model
{
    public abstract class Person_Model
    {
        public int Id;
        public string? Name;
        public string? Age;

        public abstract void Print_Data();
    }
}
