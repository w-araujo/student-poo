using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Class
{
    public class User(string name, string password, string email)
    {
        private string name = name;
        private string password = password;
        private string email = email;

        // Encapsulamento do atributo privado "name"
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

        // Encapsulamento do atributo privado "password"
        public string Password 
        {
            get { return  password; }
            set { password = value; }
        }

        // Encapsulamento do atributo privado "email"
        public string Email
        { 
            get { return email; }
            set { email = value; }
        }

        // Sobrecarga de método com informações básicas
        public void Show()
        {
            Console.WriteLine($"Nome: {name}, Email: {email}");
        }

        // Sobrecarga de método com parametro adicional
        public void Show(bool includePassword)
        {
            Show();

            if(includePassword)
            {
                Console.WriteLine($"Password - {Password}")
            }
        }
    }
}
