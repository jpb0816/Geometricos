using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometricos
{
    public class Operacion
    {

        // metodos con tipo de dato int, double,string etc. van a regresar datos, estos metodos tienen que tener return para que regrese un dato
        public double Calcular(Figura f)
        {
            double area = f.Ladoa * f.Ladob;
            return area;
        }

        public void Bienvenidos()
        {
            Console.WriteLine("Bienvenido a mi programa");

        }
    }
}
