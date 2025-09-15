using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEstrategia
{
    public class EstructuraDefensa : Estructura
    {
        public EstructuraDefensa(string nombre, int precio, int vida, int danio, Bando bando)
             : base(nombre, precio, vida, danio, bando) { }

        public override void AccionPorTurno(Juego juego, Nodo nodo)
        {
            if (this.EstaVivo())
            {
                EntidadBase objetivo = nodo.ObtenerObjetivoPara(this.Bando);
                if (objetivo != null)
                {
                    objetivo.RecibirDanio(this.Danio);
                }
            }
        }
    }

}
