using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    public class Empleado
    {

        private string nombre;
        private string puesto;
        private string diasdisponibles;
        private string horasdisponibles;
        private int nivelingles;
        public string Nombre { get; set; }
        public string Puesto { get; set; }
        public string Diasdisponibles { get; set; }
        public string Horasdisponibles { get; set; }
        public int Nivelingles { get; set; }
        public void Ra()
        {
            Console.Write("Ingrese su nombre: ");
            Nombre = Console.ReadLine();
            Console.Write("Ingrese su puesto: ");
            Puesto = Console.ReadLine();
            Console.Write("Ingrese los dias disponibles: ");
            Diasdisponibles = Console.ReadLine();
            Console.Write("Ingrese las horas en las que esta disponible: ");
            Horasdisponibles = Console.ReadLine();
            Console.Write("Ingrese su nivel de ingles(En valores numericos): ");
            Nivelingles = Convert.ToInt32(Console.ReadLine());
        }
    }
}
