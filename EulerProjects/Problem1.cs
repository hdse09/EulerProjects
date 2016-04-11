using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProjects
{
    public class Problem1
    {
        public string Nombre {
            get { return " Suma de multiplos de 3 y 5 anteriores a 1000"; }
        }

        public void GetAnswer()
        {
            Console.WriteLine("Empezando problema: "+Nombre);
            int suma = 0;
            int top = 15;
            int i = 1;
            var multiplostres = new ArrayList();
            var multiploscuatro = new ArrayList();
            var multiploscinco = new ArrayList();
            while (i*3 < top)
            {
                multiplostres.Add(i * 3);
                i++;
            }
            i = 1;
            while (i * 5 < top)
            {
                multiploscinco.Add(i * 5);
                i++;
            }
            Console.WriteLine("Respuesta : " + suma);
        }
    }
}
