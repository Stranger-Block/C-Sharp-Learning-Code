// File: Class_and_Objects.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Learning_Code._04_Class_and_Objects
{
    public class Class_and_Objects
    {
        /// <summary>
        /// Demonstrates the creation and usage of class and objects.
        /// </summary>
        public void Class_and_Objects_Function()
        {
            // Create an object of the Student_Model class
            Student_Model smit = new Student_Model();

            // Set details for the first student and print them
            smit.setDetails(1, "Smit", "Bhanushali", 12);
            smit.getDetails();

            Console.WriteLine(" "); // Print a blank line for separation

            // Create another object of the Student_Model class
            Student_Model rohan = new Student_Model();

            // Set details for the second student and print them
            rohan.setDetails(2, "Rohan", "Patel", 10);
            rohan.getDetails();
        }
    }
}