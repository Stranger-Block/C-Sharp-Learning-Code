using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Learning_Code._08_Pass_By_Value_And_Pass_By_Reference
{
    public class Pass_By_Out
    {
        public static void Pass_By_out_function()
        {
            int a;

            Console.WriteLine("\nPrint Before Update");

            Pass_By_Out_Data(out a);

            Console.WriteLine("\nPrint After Update");
            Console.WriteLine(a);
        }

        public static void Pass_By_Out_Data(out int newdata)
        {
            newdata = 20;
            newdata = newdata + 10;
            Console.WriteLine("\n" + newdata);
        }
    }
}
