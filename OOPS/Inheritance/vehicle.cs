using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.Inheritance
{
    class Vehicle        // base class (parent) 
    {
        public string brand = "Bajaj";  // Vehicle field
        public void sound()             // Vehicle method 
        {
            Console.WriteLine("Vroom,Vroom");
        }
    }

    class Bike : Vehicle  // derived class (child)
    {
        public string modelName = "Pulsar"; 
    }

  
     
    
}
