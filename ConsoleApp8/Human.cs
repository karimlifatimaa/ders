using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Human
    {
        public string Name;
        public string Surname;
        private byte _age;
        public byte Age {
            get
            {
                return _age;
            }
            set
            {
             if(value > 0) { 
                _age = value;
             }
            else
            {
                    Console.WriteLine("yas menfi ola bilmez");
            }
            }
        }
     
    }
}
