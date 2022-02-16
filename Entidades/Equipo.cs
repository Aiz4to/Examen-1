using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Equipo
    {
        //Atributos y Encapsulados

        public string _nombreEquipo { get; set; }
        public int _numeroJugadores { get; set; }
        public Jugador[] _vectorJugadores { get; set; }

        //Constructor

        public Equipo(string nombreEquipo, int numeroJugadores)
        {
            this._nombreEquipo = nombreEquipo;
            this._vectorJugadores = new Jugador[numeroJugadores];

            //Se inicializa el vector
            inicializarVect(numeroJugadores);
        }

        //Métodos

        public void inicializarVect(int tamanio)
        {
            for (int i = 0; i < tamanio; i++)
            {
                this._vectorJugadores[i]._nombre = "";
            }
        }

        public void resize(int tamVector)
        {
            //Se limpia el vector
            Array.Clear(this._vectorJugadores, 0, this._vectorJugadores.Length);

            this._vectorJugadores = new Jugador[tamVector];
            inicializarVect(tamVector);
        }

        public void escribirEquipo()
        {
            Jugador jugador = new Jugador();
            jugador.escribir(this._nombreEquipo, this._numeroJugadores, this._vectorJugadores);
        }
    }
}
