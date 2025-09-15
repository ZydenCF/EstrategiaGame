using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEstrategia
{
    public class EstructuraMantenimiento : Estructura
    {
        private int bonusConstruccion;

        public EstructuraMantenimiento(string nombre, int precio, int vida, int bonusConstruccion, Bando bando)
            : base(nombre, precio, vida, 0, bando)
        {
            this.bonusConstruccion = bonusConstruccion;
        }

        public override void AccionPorTurno(Juego juego, Nodo nodo)
        {
            if (this.EstaVivo())
            {
                juego.ModificarLimiteConstruccion(this.bonusConstruccion);
                juego.AgregarHistorial(string.Format("Estructura {0} aumentó limite de construcción en {1}.", this.Nombre, this.bonusConstruccion));
            }
        }
    }
}
