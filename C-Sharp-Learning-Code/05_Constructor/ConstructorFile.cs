// File: ConstructorFile.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Learning_Code._05_Constructor
{
    public class ConstructorFile
    {
        /// <summary>
        /// Demonstrates the usage of constructors.
        /// </summary>
        public void ConstructorFile_Function()
        {
            Example_Default_Constructor(); // Demonstrates default constructor usage
            Console.WriteLine(" ");
            Example_Parameterized_Constructor(); // Demonstrates parameterized constructor usage
            Console.WriteLine(" ");
            Example_Copy_Constructor(); // Demonstrates copy constructor usage
        }

        /// <summary>
        /// Demonstrates the use of a default constructor.
        /// </summary>
        public void Example_Default_Constructor()
        {
            Default_Constructor default_Constructor = new Default_Constructor();
        }

        /// <summary>
        /// Demonstrates the use of a parameterized constructor.
        /// </summary>
        public void Example_Parameterized_Constructor()
        {
            // Creating objects using parameterized constructor
            Parameterized_Constructor Smit = new Parameterized_Constructor(1, "Smit", "Bhanushali", 10);
            Smit.GetDetails(); // Display details of the first student

            Parameterized_Constructor Parth = new Parameterized_Constructor(2, "Parth", "Bhanushali", 11);
            Parth.GetDetails(); // Display details of the second student
        }

        /// <summary>
        /// Demonstrates the use of a copy constructor.
        /// </summary>
        public void Example_Copy_Constructor()
        {
            // Creating an object using a copy constructor
            Copy_Constructor Parth = new Copy_Constructor("Parth");
            Parth.GetDetails(); // Display the copied details
        }
    }
}