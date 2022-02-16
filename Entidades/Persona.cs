using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {

        //Atributos y Encapsulados

        public string _nombre { get; set; }
        public string _direccion { get; set; }
        public string _DNI { get; set; }

        //Constructores

        public Persona(string nombre, string direccion, string DNI)
        {
            this._nombre = nombre;
            this._direccion = direccion;
            this._DNI = DNI;
        }

        public Persona()
        {

        }

        //Métodos

        //Lee lo ingresado por el usuario
        public abstract string leer();

        public abstract string leer(string nombre);

        public abstract string escribir(string nombreEquipo, int numJugadores, Jugador[] vectorJugadores);
    }
}
