using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Learning_Code._03_Static_And_Instance_Members_Of_Class
{
    // This class represents an instance-based student with instance and static members.
    public class Instance_Student_03
    {
        // Instance variables: Unique to each object of the class.
        public int Id; // Student ID
        public string FirstName; // Student first name
        public string LastName; // Student last name
        public int Std; // Student standard/grade

        // Static variable: Shared across all objects of the class.
        public static string schoolName = "ABC School"; // Common school name for all students

        // Instance method: Calculates and prints the full name of the student.
        public void FullNameFunction()
        {
            string _FirstName = this.FirstName; // Access the current object's first name
            string _LastName = this.LastName;   // Access the current object's last name

            string fullName = _FirstName + " " + _LastName; // Concatenate first and last names
            Console.WriteLine(fullName); // Output the full name
        }

        // Instance method: Demonstrates instance and static members.
        public void Data()
        {
            // Creating an instance of Instance_Student_03 for student Ruchit
            Instance_Student_03 Ruchit = new Instance_Student_03();
            Ruchit.Id = 1;
            Ruchit.FirstName = "Ruchit";
            Ruchit.LastName = "Bhanushali";
            Ruchit.Std = 12;

            // Creating another instance of Instance_Student_03 for student Raj
            Instance_Student_03 Raj = new Instance_Student_03();
            Raj.Id = 2;
            Raj.FirstName = "Raj";
            Raj.LastName = "Patel";
            Raj.Std = 10;

            // Display details of the first student, Ruchit
            Console.WriteLine("Ruchit Details");
            Console.WriteLine(Ruchit.Id); // Print Ruchit's ID
            Console.WriteLine(Ruchit.FirstName); // Print Ruchit's first name
            Console.WriteLine(Ruchit.LastName); // Print Ruchit's last name
            Console.WriteLine(Ruchit.Std); // Print Ruchit's standard
            Ruchit.FullNameFunction(); // Print Ruchit's full name
            Console.WriteLine(Instance_Student_03.schoolName); // Print shared school name

            Console.WriteLine(""); // Blank line for separation

            // Display details of the second student, Raj
            Console.WriteLine("Raj Details");
            Console.WriteLine(Raj.Id); // Print Raj's ID
            Console.WriteLine(Raj.FirstName); // Print Raj's first name
            Console.WriteLine(Raj.LastName); // Print Raj's last name
            Console.WriteLine(Raj.Std); // Print Raj's standard
            Raj.FullNameFunction(); // Print Raj's full name
            Console.WriteLine(schoolName); // Print shared school name
        }
    }




}
