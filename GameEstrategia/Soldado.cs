using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEstrategia
{
    public class Soldado : Unidad
    {
        public Soldado(Bando bando) : base("Soldado", 50, 100, 25, 1, bando) { }
        public override bool PuedeAtacarA(Unidad objetivo) { return objetivo is Helicoptero; }
    }
}
