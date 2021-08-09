using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using taller.Propiedades;
namespace taller.Funciones
{
    class FuncionesClientes:PropiedadesClientes
    {
        public void CreandoCliente()
        {
            Console.Clear();

            Listas listas = new Listas();
            Console.WriteLine("Creando Cliente....");
            Console.Write("Nombre: ");
            Nombre = Console.ReadLine();

            Console.Write("Direccion: ");
            Dirrecion = Console.ReadLine();

            Console.Write("Telefono: ");
            Telefono = Console.ReadLine();

            Console.Write("Cedula: ");
            Codigo = Console.ReadLine();


        }
        public void BuscandoCliente()
        {
            Console.Clear();
            Listas listas = new Listas();
            Console.WriteLine("Buscando Cliente...");

            Console.Write("Digite el numero de la cedula: ");
            Codigo = Console.ReadLine();

            Console.WriteLine(Codigo);

        }
        public void ModificandoCliente()
        {
            Console.Clear();
            Listas listas = new Listas();
            Console.WriteLine("Modificando Cliente...");

            Console.Write("Digite el numero de la cedula: ");
            Codigo = Console.ReadLine();
            Console.WriteLine(Codigo);



        }
        public void EliminandoCliente()
        {
            Console.Clear();
            Listas listas = new Listas();
            Console.WriteLine("Eliminando Cliente...");

            Console.Write("Digite el numero de la cedula: ");
            Codigo = Console.ReadLine();

            Console.WriteLine(Codigo);

        }

    }
}
