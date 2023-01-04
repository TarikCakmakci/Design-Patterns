using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    //Singleton-
    public class Company
    {
        private static Company instance = new Company();
        //Contructor method should be private
        private Company(){}

        public static Company getInstance()
        {
            return instance;
        }
        public void showMessage()
        {
            Console.WriteLine("Static company object's message");
        }
    }
}
