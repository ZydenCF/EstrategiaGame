using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEstrategia
{
    public class Tanque : Unidad
    {
        public Tanque(Bando bando) : base("Tanque", 150, 200, 40, 2, bando) { }
        public override bool PuedeAtacarA(Unidad objetivo) { return objetivo is Soldado; }
    }
}
