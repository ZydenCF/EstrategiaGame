using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEstrategia
{
    public class EstructuraRecoleccion : Estructura
    {
        private int cantidadPorTurno;
        public EstructuraRecoleccion(string nombre, int precio, int vida, int cantidad, Bando bando)
            : base(nombre, precio, vida, 0, bando)
        {
            this.cantidadPorTurno = cantidad;
        }

        public override void AccionPorTurno(Juego juego, Nodo nodo)
        {
            if (this.EstaVivo())
            {
                juego.RegistrarIngresoDinero(this.cantidadPorTurno);
            }
        }
    }
}
