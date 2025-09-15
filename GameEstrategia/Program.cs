using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEstrategia
{
    public static class Program
    {
        public static void Main()
        {
            Juego j = new Juego(7);
            j.Iniciar();
        }
    }
}
