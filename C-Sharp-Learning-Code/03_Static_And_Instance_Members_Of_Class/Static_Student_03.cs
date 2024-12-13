using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Learning_Code._03_Static_And_Instance_Members_Of_Class
{
    // This class demonstrates static members of a class.
    public class Static_Student_03
    {
        // Static variables: Shared across all objects of the class.
        static int Id; // Student ID
        static string? FirstName; // Student first name
        static string? LastName; // Student last name
        static int Std; // Student standard/grade

        // Static method: Assigns values to static variables.
        static public void data()
        {
            Static_Student_03.Id = 1;
            Static_Student_03.FirstName = "Smit";
            Static_Student_03.LastName = "Khan";
            Static_Student_03.Std = 12;
        }

        // Static method: Calculates and prints the full name of the static student.
        public static void FullNameFunction()
        {
            string? _FirstName = FirstName; // Access the static first name
            string? _LastName = LastName;   // Access the static last name
            int ? _Std = Std;

            string fullName = _FirstName + " " + _LastName; // Concatenate first and last names
            Console.WriteLine(fullName); // Output the full name
            Console.WriteLine(Static_Student_03.Id);
            Console.WriteLine(_Std);
        }
    }
}
