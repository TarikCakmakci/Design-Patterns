using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //SİNGLETON
            //Company c = Company.getInstance();
            //c.showMessage();
            //Console.Read();

            //OBJECT POOL TEST
            var intPool = new objectPool<int>(
            create: () => 0,       // Create a new integer with a value of 0
            reset: i => i = 0      // Reset the integer by setting its value to 0
            );

            var number = intPool.GetObject();

            // Use the integer
            Console.WriteLine("Havuzdan alınan nesne: "+number);

            // Return the integer to the pool
            //havuza geri koyuldu
            intPool.PutObject(number);
            // Get a list of objects from the pool
            var objects = intPool.GetObjects();

            // Iterate through the objects
            foreach (var obj in objects)
            {
                Console.WriteLine("Havuzdaki nesne:"+obj);
            }
            Console.Read();
           


        }
    }
}
