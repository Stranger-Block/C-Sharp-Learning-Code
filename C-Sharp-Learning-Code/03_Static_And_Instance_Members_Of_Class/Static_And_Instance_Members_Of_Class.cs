using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Learning_Code._03_Static_And_Instance_Members_Of_Class
{
    // This class demonstrates the use of static and instance members.
    public class Static_And_Instance_Members_Of_Class
    {
        // Entry point to demonstrate the functionality of static and instance members.
        public void Static_And_Instance_Members_Of_Class_Function()
        {
            // Create an object of the current class
            Static_And_Instance_Members_Of_Class static_And_Instance_Members_Of_Class = new Static_And_Instance_Members_Of_Class();

            // Call the method to demonstrate static members
            static_And_Instance_Members_Of_Class.Static_Members();

            // Call the method to demonstrate instance members
            static_And_Instance_Members_Of_Class.Instance_Members();
        }

        // Demonstrates the usage of static members
        private void Static_Members()
        {
            Static_Student_03.data(); // Call the static method to initialize static variables
            Static_Student_03.FullNameFunction(); // Call the static method
        }

        // Demonstrates the usage of instance members
        private void Instance_Members()
        {
            Instance_Student_03 instance_Student_03 = new Instance_Student_03(); // Create an instance of Instance_Student_03
            instance_Student_03.Data(); // Call the instance method
        }
    }
}
