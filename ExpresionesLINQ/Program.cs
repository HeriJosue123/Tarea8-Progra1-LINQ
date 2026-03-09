using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpresionesLINQ
{
    class Estudiante
    {
        public string Nombre { get; set; }
        public int Nota { get; set; }

        public Estudiante(string nombre, int nota)
        {
            Nombre = nombre;
            Nota = nota;
        }

    }

    internal class Program
    {
        // Ejercicio 1 — LINQ
        //
        // Se tiene la siguiente lista de estudiantes:

        List<Estudiante> estudiantes = new List<Estudiante>()
        {
            new Estudiante("Carlos", 85),
            new Estudiante("Ana", 95),
            new Estudiante("Luis", 70),
            new Estudiante("Maria", 90),
            new Estudiante("Pedro", 60)
        };

        /*
        Problema
        Utilizando LINQ, realizar lo siguiente:

        ⚫ Mostrar únicamente los estudiantes que tengan nota mayor o igual a 80.
        ⚫ Ordenar los resultados de mayor a menor nota.
        ⚫ Mostrar el resultado en consola con el siguiente formato
         
         */


        // Ejercicio 2 — Expresiones Lambda
        //
        // Se tiene la siguiente lista de números:

        List<int> numeros = new List<int>()
        {
            3, 10, 25, 7, 18, 40, 2, 30
        };

        /*
         
        Problema
        Utilizando expresiones Lambda, realizar lo siguiente:

        ⚫ Obtener todos los números mayores que 15.
        ⚫ Calcular la suma de esos números.
        ⚫ Mostrar los resultados en consola
         
         */

        static void Main(string[] args)
        {
        }
    }
}
