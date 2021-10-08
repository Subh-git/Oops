using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.Polymorphism
{
    public class MethodOverloading
    { 
        public int add(int a,int b)  //declaring the overloading method
        {
            return a + b;
        }

        public int add(int a,int b,int c)
        {
            return a + b + c;
        }

        public int add(int a,int b, int c,int d)
        {
            return a + b + c + d;
        }

    }
}
