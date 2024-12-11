using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Learning_Code.Data_Type
{
    public class Data_Type
    {
        public void Data_Typefunction()
        {
            // Display the maximum and minimum values of an integer
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            // Display the maximum and minimum values of a float
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);

            // Declare and display a float value
            float a = 12.564f;
            Console.WriteLine(a);

            // Declare and display a double value
            double b = 12.516513215d;
            Console.WriteLine(b);

            // Declare and display a decimal value
            decimal c = 96.2651321843121m;
            Console.WriteLine(c);

            // Declare and display a string
            string name = "Smit Bhanushali";
            Console.WriteLine(name);

            // Display a string with escaped double quotes
            string newname = "\"Smit Bhanushali\"";
            Console.WriteLine(newname);

            // Display a string with escaped backslashes
            string newname2 = "\\Smit Bhanushali\\";
            Console.WriteLine(newname2);

            // Display a string with a tab character
            string newnametab = "\tSmit Bhanushali";
            Console.WriteLine(newnametab);

            // Display a string with newlines
            string newnamenextline = "Smit\n Bhanushali\n";
            Console.WriteLine(newnamenextline);

            // Declare and display a character
            char namechar = 'S';
            Console.WriteLine(namechar);

            // Another example of a character (same as above)
            char newnamechar = 'S';
            Console.WriteLine(newnamechar);

            // Declare and display a file path using escaped backslashes
            string url = "C:\\Stranger_Code\\C#\\C-Sharp-Learning-Code\\C-Sharp-Learning-Code";
            Console.WriteLine(url);

            // Declare and display the same file path using a verbatim string (no need for escaping backslashes)
            string newurl = @"C:\Stranger_Code\C#\C-Sharp-Learning-Code\C-Sharp-Learning-Code";
            Console.WriteLine(newurl);

            // Declare and display a boolean value
            bool student = true;
            Console.WriteLine(student);
        }
    }
}
