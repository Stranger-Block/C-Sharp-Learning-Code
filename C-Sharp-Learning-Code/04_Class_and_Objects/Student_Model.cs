// File: Student_Model.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Learning_Code._04_Class_and_Objects
{
    public class Student_Model
    {
        // Instance variables: Unique to each object of the class.
        public int Id; // Student ID
        public string FirstName; // Student first name
        public string LastName; // Student last name
        public int Std; // Student standard/grade

        /// <summary>
        /// Sets the details of a student.
        /// </summary>
        /// <param name="id">Student ID</param>
        /// <param name="fname">Student first name</param>
        /// <param name="lname">Student last name</param>
        /// <param name="std">Student standard/grade</param>
        public void setDetails(int id, string fname, string lname, int std)
        {
            this.Id = id; // Assign the provided ID to the instance variable
            this.FirstName = fname; // Assign the provided first name to the instance variable
            this.LastName = lname; // Assign the provided last name to the instance variable
            this.Std = std; // Assign the provided standard to the instance variable
        }

        /// <summary>
        /// Retrieves and prints the details of a student.
        /// </summary>
        public void getDetails()
        {
            // Print each detail of the student
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("First Name: " + FirstName);
            Console.WriteLine("Last Name: " + LastName);
            Console.WriteLine("Standard: " + Std);
        }
    }
}