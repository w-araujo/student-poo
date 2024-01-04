using Student.Class;
using Student.src.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Student.src.Class
{
    // Herança da classe "User"
    public class Students : User
    {
        private int registration;

        // Construtor público forçando a entrada dos dados da classe User com o "Base"
        public Students(int registration, string name, string password, string email) : base(name, password, email)
        {
            this.registration = registration;
        }

        // Encapsulamento do atributo privado "registration"
        public int Registration
        {
            get { return registration; }
            set { registration = value; }
        }
        // Sobrescrita do método polimórfico Greet da classe base
        public override void Greet()
        {
            Console.WriteLine($"Olá: {this.Name}! (Estudante - Matricula: {registration})");
            base.Greet();
        }
    }
}
