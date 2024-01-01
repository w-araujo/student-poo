using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.src.Interfaces
{
    // Contrato para ser implementado nas classes
    public interface IUser
    {
        string Name { get; set; }
        string Password { get; set; }
        string Email { get; set; }

        void Show();
        void Show(bool includePassword);
    }
}