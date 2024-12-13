using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Learning_Code._07_VAR_And_Dynamic_Keywords
{
    public class VAR_And_Dynamic_Keywords
    {
        public void VAR_And_Dynamic_Keywords_Function()
        {
            Var_Keyword();
            Console.WriteLine(" ");
            Dynamic_Keyword();
        }

        public void Var_Keyword()
        {
            //initialize at compilation is needed
            // value type 
            var a = 20;
            
            // now b is immutable we dont change it
            var b = 15;
            Console.WriteLine(b);
            Console.WriteLine(b.GetType().Name);

            Console.WriteLine(a);
            Console.WriteLine(a.GetType().Name);
        }

        //// not possible to return var and pass value as var
        //public void Var_Keyword2(var b)
        //{
        //    var a = b;
        //}

        public void Dynamic_Keyword()
        {
            //initialize at runtime
            // refrence tpe
            dynamic a;

            // now b is mutable we change it
            dynamic b = 15;
            b = 16;
            Console.WriteLine(b);
            Console.WriteLine(b.GetType().Name);

            a = 66;
            Console.WriteLine(a);
            Console.WriteLine(a.GetType().Name);



        }

        // possible to return dynamic and pass value as daynamic
        public dynamic Daynamic_Keyword2(dynamic b)
        {
            dynamic end = 15;
            return end;
        }

    }
}
