using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Learning_Code._06_Value_Type_And_Reference_Type
{
    public class Value_Type_And_Reference_Type
    {
        public void Value_Type_And_Reference_Type_Function()
        {
            Console.WriteLine("Value Type");
            Value_Type_Class struct_Class = new Value_Type_Class();
            struct_Class.GetDetails();

            Console.WriteLine("\nReference Type");
            Reference_Type_Class reference_Type_Class = new Reference_Type_Class();
            reference_Type_Class.GetDetails();
        }
    }
}
