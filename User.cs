using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkConsoleApp
{
    class User
    {
        public string firstName;
        public string lastName;
        public int age;
        public List<string> listString;
        public User(string firstName,string lastName,int age) 
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }
        public User() { }
    }
}
