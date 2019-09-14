using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometricos
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //instanciacion de objetos
            
            Figura rectangulo1 = new Figura();

            rectangulo1.Ladoa = 4;
            rectangulo1.Ladob = 5;

            Figura rectangulo2 = new Figura();

            rectangulo2.Ladoa = 4;
            rectangulo2.Ladob = 3;

            Figura rectangulo3 = new Figura();

            rectangulo3.Ladoa = 5;
            rectangulo3.Ladob = 6;

            Operacion op = new Operacion();
            op.Bienvenidos();
           
            // Se tiene que asignar una variable para llamar el metodo cuando este tiene que regresar valor

            // al imprimir el resultado se tiene que insertar la variable a calcular, no el objeto
            double area=op.Calcular(rectangulo1);
            Console.WriteLine("\nValor del primer objeto");
            Console.WriteLine(area);

            Console.WriteLine("\nValor del segundo objeto");
            double area2 = op.Calcular(rectangulo2);
            Console.WriteLine(area2);

            Console.WriteLine("\nValor del tercer objeto");
            double area3 = op.Calcular(rectangulo3);
            Console.WriteLine(area3);
            Console.ReadKey();
        }
    }
}
