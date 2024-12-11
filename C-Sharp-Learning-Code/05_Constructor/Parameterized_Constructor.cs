// File: Parameterized_Constructor.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Learning_Code._05_Constructor
{
    public class Parameterized_Constructor
    {
        // Instance variables: Unique to each object of the class.
        public int Id; // Student ID
        public string FirstName; // Student first name
        public string LastName; // Student last name
        public int Std; // Student standard/grade 

        /// <summary>
        /// Parameterized constructor: Initializes an object with the provided values.
        /// </summary>
        /// <param name="Id">Student ID</param>
        /// <param name="FirstName">Student first name</param>
        /// <param name="LastName">Student last name</param>
        /// <param name="Std">Student standard/grade</param>
        public Parameterized_Constructor(int Id, string FirstName, string LastName, int Std)
        {
            this.Id = Id; // Assign the provided ID to the instance variable
            this.FirstName = FirstName; // Assign the provided first name to the instance variable
            this.LastName = LastName; // Assign the provided last name to the instance variable
            this.Std = Std; // Assign the provided standard to the instance variable
        }

        /// <summary>
        /// Displays the details stored in the object.
        /// </summary>
        public void GetDetails()
        {
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("First Name: " + FirstName);
            Console.WriteLine("Last Name: " + LastName);
            Console.WriteLine("Standard: " + Std);
        }
    }
}