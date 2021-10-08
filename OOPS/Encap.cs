using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class Encap
    {

        // private variables declared
        // these can only be accessed by
        // public methods of class

        private string studentName;
        private int studentAge;
        private string studentStream;

        // using accessors to get and 
        // set the value of studentName
        public string Name
        
            {
                get
                {
                    return studentName;
                }

            
                set
            
                {
                
                    studentName = value;
            
                }

        
            }

        // using accessors to get and 
        // set the value of studentAge
        public int Age        
            {
            
                get           
                {
                    return studentAge;
                }
                set
            
                {
                    studentAge = value;
                }
        
            }

            public string Stream

            {
                get
                {
                    return studentStream;
                }


                set

                {

                    studentStream = value;

                }


            }
        }

}

