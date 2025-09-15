using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEstrategia
{
    public class EstructuraDefensa : Estructura
    {
        private int alcance;
        public EstructuraDefensa(string nombre, int precio, int vida, int danio, int alcance, Bando bando)
            : base(nombre, precio, vida, danio, bando)
        {
            this.alcance = alcance;
        }

        public override void AccionPorTurno(Juego juego, Nodo nodo)
        {
            if (this.EstaVivo())
            {
                EntidadBase objetivo = nodo.ObtenerObjetivoPara(this.Bando);
                if (objetivo != null)
                {
                    objetivo.RecibirDanio(this.Danio);
                    juego.AgregarHistorial(string.Format("Estructura {0} atacó a {1} por {2} daño.", this.Nombre, objetivo.Nombre, this.Danio));
                }
            }
        }
    }

}
