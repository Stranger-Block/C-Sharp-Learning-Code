using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Learning_Code._05_Constructor
{
    public class Copy_Constructor
    {
        // Instance variable to store the name
        string name = "Smit Bhanushali"; // Default name

        /// <summary>
        /// Copy constructor to initialize an object with another object's data.
        /// </summary>
        /// <param name="name">Name to initialize with</param>
        public Copy_Constructor(string name)
        {
            this.name = name; // Assign the provided name to the instance variable
        }

        /// <summary>
        /// Displays the details stored in the object.
        /// </summary>
        public void GetDetails()
        {
            Console.WriteLine("Name: " + name);
        }
    }
}