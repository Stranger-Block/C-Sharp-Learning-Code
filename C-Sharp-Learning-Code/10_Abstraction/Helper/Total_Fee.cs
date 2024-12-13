using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Learning_Code._10_Abstraction.Helper
{
    public static class Total_Fee
    {
        private static void Calculate_Fee_Method(int incomedata)
        {
            if (incomedata < 2000)
            {
                //Scholarship = "25%";
                //fee = incomedata - (incomedata * 0.25);
                Console.WriteLine("25% Scholarship");
            }
            else if (incomedata >= 2000 && incomedata < 10000)
            {
                //Scholarship = "15%";
                //fee = incomedata - (incomedata * 0.15);
                Console.WriteLine("15% Scholarship");
            }
            else
            {
                //Scholarship = "0%";
                //fee = incomedata;
                Console.WriteLine("No Scholarship");
            }
        }

        public static void Total_Fee_Method(int id, string name, int income)
        {
            Console.WriteLine(id);
            Console.WriteLine(name);
            Console.WriteLine(income);
            Calculate_Fee_Method(income);
            //Console.WriteLine(scholarship);
            //Console.WriteLine(fee);
        }
    }
}
