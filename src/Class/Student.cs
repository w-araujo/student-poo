using Student.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.src.Class
{
    public class Student : User
    {
        private int registration;

        public Student(int registration, string name, string password, string email) : base(name, password, email)
        {
            this.registration = registration;
        }

        public int Registration
        {
            get { return registration; }
            set { registration = value; }
        }
    }
}
