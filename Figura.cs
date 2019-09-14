using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometricos
{
    public class Figura
    {
        //Encapsulacion
        // se asignan los atributos que tendra el objeto a crear
        private double ladoa;
        private double ladob;

        public double Ladoa
        {
            get { return ladoa; }
            set { ladoa = value; }

        }

        public double Ladob
        {
            get { return ladob; }
            set { ladob = value; }

        }
    }
}
