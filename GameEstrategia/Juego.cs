using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEstrategia
{
    public class Juego
    {
        private List<Nodo> mapa;
        private int dinero;
        private int limiteConstruccion;
        private int turno;
        private bool terminado;
        private Fibonacci fib;
        private Stack<string> historial;
        private Queue<Unidad> cola;
        private Dictionary<TipoUnidad, int> contador;

        public Juego(int nodos)
        {
            this.mapa = new List<Nodo>();
            for (int i = 0; i < nodos; i++) this.mapa.Add(new Nodo(i));
            this.dinero = 200;
            this.limiteConstruccion = 2;
            this.turno = 1;
            this.terminado = false;
            this.fib = new Fibonacci();
            this.historial = new Stack<string>();
            this.cola = new Queue<Unidad>();
            this.contador = new Dictionary<TipoUnidad, int>();
            this.contador[TipoUnidad.Soldado] = 0;
            this.contador[TipoUnidad.Tanque] = 0;
            this.contador[TipoUnidad.Helicoptero] = 0;
        }

        public void RegistrarIngresoDinero(int c) { this.dinero += c; }
        public void ModificarLimiteConstruccion(int d) { this.limiteConstruccion += d; }

        public void Iniciar()
        {
            while (!terminado)
            {
                Console.WriteLine("Turno " + turno + " Dinero: " + dinero);
                Console.WriteLine("1.Crear Soldado 2.Crear Tanque 3.Crear Helicoptero 4.Crear Recolector 5.Pasar");
                string op = Console.ReadLine();
                if (op == "1" && dinero >= 50) { mapa[0].AgregarEntidad(new Soldado(Bando.Jugador)); dinero -= 50; }
                else if (op == "2" && dinero >= 150) { mapa[0].AgregarEntidad(new Tanque(Bando.Jugador)); dinero -= 150; }
                else if (op == "3" && dinero >= 300) { mapa[0].AgregarEntidad(new Helicoptero(Bando.Jugador)); dinero -= 300; }
                else if (op == "4" && dinero >= 100) { mapa[0].AgregarEntidad(new EstructuraRecoleccion("Recolector", 100, 150, 50, Bando.Jugador)); dinero -= 100; }
                else if (op == "5") { turno++; }
                else { Console.WriteLine("Opción inválida"); }
                if (turno > 10) terminado = true;
            }
        }
    }
}
