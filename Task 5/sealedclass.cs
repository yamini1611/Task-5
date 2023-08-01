using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{

    sealed public  class Employee
    {
        public void trainee()
        {
            Console.WriteLine(".NET Trainees");
        }
    }

     public  class  Developer:Employee
    {
        public void Selected()
        {
            Console.WriteLine("Selected trainees");
        }
    }

    public class Display
    {
        static void Main(string[] args)
        {
            Developer dev = new Developer();
            dev.trainee();

            dev.Selected();
        }
     
    }
    
}
