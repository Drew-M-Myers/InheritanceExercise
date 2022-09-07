using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Animal
    {
        // Create a class Animal
        // give this class 4 members that all Animals have in common
        public Animal()
        {
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public int NumberOfLegs { get; set; }   
        public bool IsAlive { get; set; }
    }
}
