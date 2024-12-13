using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Learning_Code._12_Properties.Model
{
    public class Emp_Model_Class
    {
        public int RollNumber { get; private set; }
        public string? FatherName { get; private set; }
        public int Id { get; set; }
        public string? Name { get; set; }

    }
}
