using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0, r=0;
            char n;
            Empleado objeto = new Empleado();
            do
            {
                objeto.Ra();
                Console.WriteLine("Continue?      Y/N");
                do {
                    n = Convert.ToChar(Console.ReadLine());
                    if (n == 'Y')
                    {
                        Console.WriteLine("");
                        r++;
                    }
                    else if (n == 'N')
                    {
                        r++;
                        k++;
                    }
                    else
                    {
                        Console.WriteLine("Tecla equivocada");
                    }
                }
                while (r<=0);
            }
            while (k <= 0);
            Console.WriteLine("Vuelva pronto");
            Console.ReadKey();
            
        }
    }
}
