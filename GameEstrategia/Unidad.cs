using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEstrategia
{
    public abstract class Unidad : EntidadBase, IMovible
    {
        public int Precio { get; protected set; }
        public int Velocidad { get; protected set; }

        protected Unidad(string nombre, int precio, int vida, int danio, int velocidad, Bando bando)
            : base(nombre, vida, danio, bando)
        {
            this.Precio = precio;
            this.Velocidad = velocidad;
        }

        public abstract bool PuedeAtacarA(Unidad objetivo);

    }
}