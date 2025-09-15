using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEstrategia
{
    internal interface ICombatiente
    {
        string Nombre { get; }
        int Vida { get; set; }
        int Daño { get; }
        bool EstaVivo { get; }

        void RecibirDaño(int daño);
    }
}
