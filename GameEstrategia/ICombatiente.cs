using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEstrategia
{
    public interface ICombatiente
    {
        string Nombre { get; }
        int Vida { get; }
        int Danio { get; }
        Bando Bando { get; }
        bool EstaVivo();
        void RecibirDanio(int danio);
    }
}
