using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador : Persona
    {
        //Atributos y Encapsulados

        public string _puesto { get; set; }
        //Posibles valores: base, escolta, alero, ala-pivot y pivot

        //Jugador
        Jugador jugador = new Jugador();

        //Constructores

        public Jugador(string nombre, string direccion, string DNI, string puesto)
            : base(nombre, direccion, DNI)
        {
            this._puesto = puesto;
        }

        public Jugador()
        {

        }

        public override string escribir(string nombreEquipo, int numJugadores, Jugador[] vectorJugadores)
        {
            Console.WriteLine("Nombre del Equipo: " + nombreEquipo);
            Console.WriteLine("Cantidad de jugadores: " + numJugadores);
            Console.WriteLine("Lista de jugadores:");
            Console.WriteLine();
            for (int i = 0; i < vectorJugadores.Length; i++)
            {
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Jugador " + i+1 + ". " + vectorJugadores[i]._nombre);
                Console.WriteLine("Dirección: " + vectorJugadores[i]._direccion);
                Console.WriteLine("DNI: " + vectorJugadores[i]._DNI);
                Console.WriteLine("Posición: " + vectorJugadores[i]._puesto);

            }
            Console.WriteLine("--------------------------------------------------");

            return "Estoy escribiendo.";
        }

        //Lee los datos de un jugador
        public override string leer()
        {
            jugador = new Jugador();

            Console.WriteLine("Ingrese el nombre del Jugador: ");
            jugador._nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la dirección del Jugador: ");
            jugador._direccion = Console.ReadLine();
            Console.WriteLine("Ingrese el DNI del Jugador: ");
            jugador._DNI = Console.ReadLine();
            Console.WriteLine("Ingrese el puesto del Jugador: ");
            Console.WriteLine("Posiciones: Base, Escolta, Alero, Ala-Pivot, Pivot");
            jugador._puesto = Console.ReadLine();

            return "Estoy leyendo.";
        }

        //Escribe un mensaje y lee por consola
        public override string leer(string mensaje)
        {
            Console.WriteLine(mensaje);
            return Console.ReadLine();
        }

        public string jugar(string nombreJugador)
        {
            return "Estoy jugando " + nombreJugador;
        }
    }
}
