using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEstrategia
{
    public abstract class EntidadBase : ICombatiente
    {
        public string Nombre { get; protected set; }
        public int Vida { get; protected set; }
        public int Danio { get; protected set; }
        public Bando Bando { get; protected set; }

        protected EntidadBase(string nombre, int vida, int danio, Bando bando)
        {
            this.Nombre = nombre;
            this.Vida = vida;
            this.Danio = danio;
            this.Bando = bando;
        }

        public bool EstaVivo()
        {
            return this.Vida > 0;
        }

        public virtual void RecibirDanio(int danio)
        {
            if (danio < 0) throw new ArgumentException("El daño no puede ser negativo");
            this.Vida -= danio;
            if (this.Vida < 0) this.Vida = 0;
        }

        public override string ToString()
        {
            return string.Format("{0} ({1}) Vida:{2} Danio:{3}", this.Nombre, this.Bando, this.Vida, this.Danio);
        }
    }
}
