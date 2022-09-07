using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Reptile : Animal
    {
        // Create a class Reptile
        // give this class 4 members that are specific to Reptile
        // Set this class to inherit from your Animal Class
        public Reptile()
        {
        }

        public bool DoesItHaveScales { get; set; }  
        public string WhatIsItsHabitat { get; set; }
        public bool DoesItSwim { get; set; }
        public bool IsItColdBlooded { get; set; }
    }
}
