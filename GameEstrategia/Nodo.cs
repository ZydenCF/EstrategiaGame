using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEstrategia
{
    public class Nodo
    {
        public int Indice { get; private set; }
        private List<EntidadBase> entidades;

        public Nodo(int indice)
        {
            this.Indice = indice;
            this.entidades = new List<EntidadBase>();
        }

        public void AgregarEntidad(EntidadBase e) { this.entidades.Add(e); }
        public void RemoverEntidad(EntidadBase e) { this.entidades.Remove(e); }
        public List<EntidadBase> ObtenerEntidades() { return new List<EntidadBase>(this.entidades); }

        public bool TieneCombate()
        {
            bool jugador = false, enemigo = false;
            foreach (EntidadBase e in this.entidades)
            {
                if (e.Bando == Bando.Jugador && e.EstaVivo()) jugador = true;
                if (e.Bando == Bando.Enemigo && e.EstaVivo()) enemigo = true;
            }
            return jugador && enemigo;
        }

        public EntidadBase ObtenerObjetivoPara(Bando bando)
        {
            foreach (EntidadBase e in this.entidades)
            {
                if (e.Bando != bando && e.EstaVivo() && e is Unidad) return e;
            }
            foreach (EntidadBase e in this.entidades)
            {
                if (e.Bando != bando && e.EstaVivo() && e is EstructuraDefensa) return e;
            }
            foreach (EntidadBase e in this.entidades)
            {
                if (e.Bando != bando && e.EstaVivo() && e is EstructuraMantenimiento) return e;
            }
            return null;
        }

        public void LimpiarMuertos()
        {
            this.entidades.RemoveAll(e => !e.EstaVivo());
        }
    }
}