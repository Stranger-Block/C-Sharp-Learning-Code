using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Learning_Code._08_Pass_By_Value_And_Pass_By_Reference
{
    public static class Pass_By_Value
    {
        public static void Pass_By_Value_function()
        {
            int a = 5;

            Console.WriteLine("\nPrint Before Update");
            Console.WriteLine(a);

            Pass_By_Value_Data(a);

            Console.WriteLine("\nPrint After Update");
            Console.WriteLine(a);
        }

        public static void Pass_By_Value_Data(int newdata)
        {
            newdata = newdata + 10;
            Console.WriteLine("\n" + newdata);
        }
    }
}
