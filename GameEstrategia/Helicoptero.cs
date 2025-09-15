using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEstrategia
{
    public class Helicoptero : Unidad
    {
        public Helicoptero(Bando bando) : base("Helicoptero", 300, 120, 60, 3, bando) { }
        public override bool PuedeAtacarA(Unidad objetivo) { return objetivo is Tanque; }
    }
}
