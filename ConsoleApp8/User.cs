using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class User: Human
    {

        private string _userName;
        private string _password;
        public string UserName {
            get 
            { 
                return _userName;
            }
            set
            { 
                if( value.Length>=6 && value.Length<= 25) { 
                    _userName = value;
                }
                else
                {
                    Console.WriteLine("olcuye uygun deyer daxil et");
                }
                
            }
        }
        public string Password {
            get
            {
                return _password;
            }
            set
            {
                if (value.Length >= 8 && value.Length <= 25)
                {
                    _password = value;
                }
                else
                {
                    Console.WriteLine("olcuye uygun deyer daxil et");
                }
            }
        }

        public User(string name,string surname,byte age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

    }
}
