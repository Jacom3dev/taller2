using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taller
{
    class Configuracion
    {
        string nombrePrograma ;
        public void PerdirNombre()
        {
            Console.WriteLine("---------- CONFIGURACION ----------");
            Console.Write("Nombre del negocio: ");
            nombrePrograma = Console.ReadLine();
          
        }

        public void MostrarNombre()
        {
            Console.WriteLine($"------- Bienvenido a {nombrePrograma} ----------");
        }
    }
}
