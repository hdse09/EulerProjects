using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Empezando Problemas");
            Console.WriteLine("Tiempo Inicio "+DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss.fff tt"));
            Problem1 problem = new Problem1();
            problem.GetAnswer();
            Console.WriteLine("Tiempo Fin " + DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss.fff tt"));
            Console.ReadLine();
        }
    }
}
