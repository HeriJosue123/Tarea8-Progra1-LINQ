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
        // Se dejaron los nombres originales del Inge
        static List<Estudiante> estudiantes = new List<Estudiante>()
        {
            new Estudiante("Carlos", 85),
            new Estudiante("Ana", 95),
            new Estudiante("Luis", 70),
            new Estudiante("Maria", 90),
            new Estudiante("Pedro", 60)
        };

        static List<int> numeros = new List<int>()
        {
            3, 10, 25, 7, 18, 40, 2, 30
        };

        static void Main(string[] args)
        {
            // --- EJERCICIO 1: LINQ ---
            Console.WriteLine("--- Estudiantes Sobresalientes ---");

            var estudiantesSobresalientes = from e in estudiantes
                                            where e.Nota >= 80
                                            orderby e.Nota descending
                                            select e;

            foreach (var est in estudiantesSobresalientes)
            {
                Console.WriteLine($"Nombre: {est.Nombre} - Nota: {est.Nota}");
            }

            // --- EJERCICIO 2: LAMBDA ---
            Console.WriteLine("\n--- Numeros Mayores a 15 ---");

            var numerosMayores = numeros.Where(n => n > 15).ToList();
            int suma = numerosMayores.Sum();

            foreach (var num in numerosMayores)
            {
                Console.WriteLine($"- {num}");
            }

            Console.WriteLine($"\nLa suma total de esos números es: {suma}");

            // --- PAUSA FINAL ---
            Console.WriteLine("\nPresiona Enter para finalizar...");
            Console.ReadLine();
        }
    }
}
