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

        public void AgregarEntidad(EntidadBase e)
        {
            if (e == null) return;
            this.entidades.Add(e);
        }

        public void RemoverEntidad(EntidadBase e)
        {
            if (e == null) return;
            this.entidades.Remove(e);
        }

        public List<EntidadBase> ObtenerEntidades()
        {
            return new List<EntidadBase>(this.entidades);
        }

        
        public bool TieneCombate()
        {
            bool hayJugador = false;
            bool hayEnemigo = false;
            int i = 0;
            for (i = 0; i < this.entidades.Count; i++)
            {
                EntidadBase e = this.entidades[i];
                if (e.Bando == Bando.Jugador && e.EstaVivo()) hayJugador = true;
                if (e.Bando == Bando.Enemigo && e.EstaVivo()) hayEnemigo = true;
                if (hayJugador && hayEnemigo) return true;
            }
            return false;
        }

        
        public EntidadBase ObtenerObjetivoPara(Bando atacanteBando)
        {
            
            int i = 0;
            for (i = 0; i < this.entidades.Count; i++)
            {
                EntidadBase e = this.entidades[i];
                if (e.Bando != atacanteBando && e.EstaVivo() && e is Unidad) return e;
            }
            
            for (i = 0; i < this.entidades.Count; i++)
            {
                EntidadBase e = this.entidades[i];
                if (e.Bando != atacanteBando && e.EstaVivo() && e is EstructuraDefensa) return e;
            }
            
            for (i = 0; i < this.entidades.Count; i++)
            {
                EntidadBase e = this.entidades[i];
                if (e.Bando != atacanteBando && e.EstaVivo() && e is EstructuraMantenimiento) return e;
            }
            
            for (i = 0; i < this.entidades.Count; i++)
            {
                EntidadBase e = this.entidades[i];
                if (e.Bando != atacanteBando && e.EstaVivo() && e is Estructura) return e;
            }
            return null;
        }

        
        public Unidad ObtenerUnidadObjetivoPara(Unidad atacante)
        {
            int i = 0;
            
            for (i = 0; i < this.entidades.Count; i++)
            {
                EntidadBase e = this.entidades[i];
                if (e.EstaVivo() && e.Bando != atacante.Bando && e is Unidad)
                {
                    Unidad u = (Unidad)e;
                    if (atacante.PuedeAtacarA(u))
                    {
                        return u;
                    }
                }
            }
           
            for (i = 0; i < this.entidades.Count; i++)
            {
                EntidadBase e = this.entidades[i];
                if (e.EstaVivo() && e.Bando != atacante.Bando && e is EstructuraDefensa) return (Unidad)null;
            }
            
            return null;
        }

        
        public Estructura ObtenerEstructuraEnemiga(Bando atacanteBando)
        {
            int i = 0;
            for (i = 0; i < this.entidades.Count; i++)
            {
                EntidadBase e = this.entidades[i];
                if (e.EstaVivo() && e.Bando != atacanteBando && e is Estructura)
                {
                    return (Estructura)e;
                }
            }
            return null;
        }

        
        public void LimpiarMuertos()
        {
            List<EntidadBase> aRemover = new List<EntidadBase>();
            int i = 0;
            for (i = 0; i < this.entidades.Count; i++)
            {
                EntidadBase e = this.entidades[i];
                if (!e.EstaVivo())
                {
                    aRemover.Add(e);
                }
            }
            for (i = 0; i < aRemover.Count; i++)
            {
                this.entidades.Remove(aRemover[i]);
            }
        }
    }
}
