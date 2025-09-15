using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEstrategia
{
    public abstract class Estructura : EntidadBase
    {
        public int Precio { get; protected set; }

        protected Estructura(string nombre, int precio, int vida, int danio, Bando bando)
            : base(nombre, vida, danio, bando)
        {
            this.Precio = precio;
        }

        public abstract void AccionPorTurno(Juego juego, Nodo nodo);
    }
}
