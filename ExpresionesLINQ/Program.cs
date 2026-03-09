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
      
        static List<Estudiante> estudiantes = new List<Estudiante>()
        {
            new Estudiante("David", 85),
            new Estudiante("Ludy", 95),
            new Estudiante("Susana", 70),
            new Estudiante("Yeyson", 90),
            new Estudiante("Heriberto", 60)
        };

        static List<int> numeros = new List<int>()
        {
            3, 10, 25, 7, 18, 40, 2, 30
        };

       
        static void Main(string[] args)
        {
            // --- EJERCICIO 1: LINQ ---
            Console.WriteLine("--- Estudiantes Sobresalientes ---");

            var EstudiantesSobresalientess = from e in estudiantes
                                        where e.Nota >= 80
                                        orderby e.Nota descending
                                        select e;

            foreach (var est in EstudiantesSobresalientess)
            {
                Console.WriteLine($"Nombre: {est.Nombre} - Nota: {est.Nota}");
            }


            // --- EJERCICIO 2: LAMBDA ---
            Console.WriteLine("\n--- Numeros Mayores a 15 ---");

            var NumerosMayores = numeros.Where(n => n > 15).ToList();
            int suma = NumerosMayores.Sum();

            foreach (var num in NumerosMayores)
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