using Student.src.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Class
{
    // Henrança com a interface IUser, para implementar o contrato
    public class User(string name, string password, string email) : IUser
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
        public void Greet()
        {
            Console.WriteLine($"Nome: {name}, Email: {email}");
        }

        // Sobrecarga de método com parametro adicional
        public void Greet(bool includePassword)
        {
            Greet();

            if(includePassword)
            {
                Console.WriteLine($"Password - {Password}");
            }
        }

        // Método estático para gerar senhas aleatórias (Sem precisar de instâncias)
        public static string GenerateRandomPassword(int length = 8)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
