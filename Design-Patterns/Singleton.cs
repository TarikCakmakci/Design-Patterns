using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Design_Patterns
{
    public sealed class Singleton
    {
        public int size { get; set; }
        public string name { get; set; }

        private static readonly Lazy<Singleton> _instance = new Lazy<Singleton>(() => new Singleton());

        //private static readonly object padlock = new object();
        private Singleton() { }
        public static Singleton Instance
        {
            get
            {
                return _instance.Value;
            }
        }
       

    }
}
