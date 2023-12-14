using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Class
{
    internal class User(string name, string password, string email)
    {
        private string name = name;
        private string password = password;
        private string email = email;

        public string Name
        {  
            get {  return name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentException("The name cannot be empty!");
                }   
            }
        }
        public string Password 
        {
            get { return  password; }
            set { password = value; }
        }
        public string Email
        { 
            get { return email; }
            set { email = value; }
        }
        public void Show()
        {
            Console.WriteLine($"Nome: {name}, Password: {password}, Email: {email}");
        }
    }
}
