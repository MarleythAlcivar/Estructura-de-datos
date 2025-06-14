using System;

namespace RegistroEstudiante
{
    // Clase Estudiante
    public class Estudiante
    {
        // Propiedades
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string[] Telefonos { get; set; } = new string[3]; // Array de 3 teléfonos

        // Método para mostrar la información del estudiante
        public void MostrarInformacion()
        {
            Console.WriteLine("----- Información del Estudiante -----");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Nombres: {Nombres}");
            Console.WriteLine($"Apellidos: {Apellidos}");
            Console.WriteLine($"Dirección: {Direccion}");
            Console.WriteLine("Teléfonos:");
            for (int i = 0; i < Telefonos.Length; i++)
            {
                Console.WriteLine($"  Teléfono {i + 1}: {Telefonos[i]}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Crear una instancia de estudiante
            Estudiante estudiante = new Estudiante();

            // Ingreso de datos por consola
            Console.Write("Ingrese el ID: ");
            estudiante.Id = int.Parse(Console.ReadLine());

            Console.Write("Ingrese los nombres: ");
            estudiante.Nombres = Console.ReadLine();

            Console.Write("Ingrese los apellidos: ");
            estudiante.Apellidos = Console.ReadLine();

            Console.Write("Ingrese la dirección: ");
            estudiante.Direccion = Console.ReadLine();

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Ingrese el teléfono {i + 1}: ");
                estudiante.Telefonos[i] = Console.ReadLine();
            }

            // Mostrar la información del estudiante
            Console.Clear(); // Limpia la consola
            estudiante.MostrarInformacion();
        }
    }
}
