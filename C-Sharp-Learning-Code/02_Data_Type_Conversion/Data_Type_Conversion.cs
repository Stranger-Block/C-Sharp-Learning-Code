using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Learning_Code._02_Data_Type_Conversion
{
    // This namespace contains code related to data type conversion in C#
    public class Data_Type_Conversion
    {
        // This method demonstrates various types of data type conversions in C#
        public void Data_Type_Conversion_function()
        {
            // Implicit conversion: Automatically converting a smaller type (int) to a larger type (float)
            int a = 20;
            float b = a; // No data loss, safe conversion
            Console.WriteLine(b); // Output: 20

            // Explicit conversion using casting: Converting a larger type (float) to a smaller type (int)
            float c = 10.5f;
            int d = (int)c; // Data loss: fractional part is truncated
            Console.WriteLine(d); // Output: 10

            // Explicit conversion using Convert class: Rounds the number before converting
            float e = 20.5f;
            int f = Convert.ToInt32(e); // Rounds 20.5 to 21 before conversion
            Console.WriteLine(f); // Output: 21

            // Converting a string to an integer using Convert.ToInt32
            string g = "123";
            int h = Convert.ToInt32(g); // Converts the numeric string to an integer
            Console.WriteLine(h); // Output: 123

            // Converting a string to an integer using int.Parse
            string i = "123";
            int j = int.Parse(i); // Parses the numeric string to an integer
            Console.WriteLine(j); // Output: 123

            // Converting a string to a float using float.Parse
            string k = "123.546";
            float l = float.Parse(k); // Parses the numeric string to a float
            Console.WriteLine(l); // Output: 123.546

            // Reading user input and converting to integer using Convert.ToInt32
            Console.WriteLine("Enter your age.");
            int x = Convert.ToInt32(Console.ReadLine()); // Takes input, converts to int
            Console.WriteLine($"Your age is: {x}");

            // Reading user input and converting to integer using int.Parse
            Console.WriteLine("Enter your age.");
            int y = int.Parse(Console.ReadLine()); // Takes input, parses it as int
            Console.WriteLine($"Your age is: {y}");

            // Reading user input and converting to float using float.Parse
            Console.WriteLine("Enter your age.");
            float z = float.Parse(Console.ReadLine()); // Takes input, parses it as float
            Console.WriteLine($"Your age in float is: {z}");
        }
    }
}
