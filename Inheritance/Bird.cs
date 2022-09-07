using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Bird : Animal
    {
        // Create a class Bird
        // give this class 4 members that are specific to Bird
        // Set this class to inherit from your Animal Class
        public Bird()
        {
        }
        public string Type { get; set; }
        public bool DoesItFly { get; set; }
        public string Color { get; set; }
        public bool DoesItMigrate { get; set; }
    }
}
