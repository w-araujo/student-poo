using Student.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.src.Class
{
    // Herança da classe "User"
    public class Student : User
    {
        private int registration;

        // Construtor público forçando a entrada dos dados da classe User com o "Base"
        public Student(int registration, string name, string password, string email) : base(name, password, email)
        {
            this.registration = registration;
        }

        // Encapsulamento do atributo privado "registration"
        public int Registration
        {
            get { return registration; }
            set { registration = value; }
        }
    }
}
