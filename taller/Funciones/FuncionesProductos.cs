using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using taller.Propiedades;
namespace taller.Funciones
{
    class FuncionesProductos:PropiedadesProductos
    {
        public void CreandoProdcuto()
        {
            Console.Clear();

            Listas listas = new Listas();
            Console.WriteLine("Creando Producto....");

            Console.Write("Nombre: ");
            Nombre = Console.ReadLine();

            Console.Write("Precio: ");
            Precio = float.Parse(Console.ReadLine());

            Console.Write("Cantidad: ");
            Cantidad = int.Parse(Console.ReadLine());

            Console.Write("codigo: ");
            Codigo = Console.ReadLine();

        }
        public void BuscandoProducto()
        {
            Console.Clear();
            Listas listas = new Listas();
            Console.WriteLine("Buscando Producto...");

            Console.Write("Digite  codigo: ");
            Codigo = Console.ReadLine();

            Console.WriteLine(Codigo);

        }

        public void ModificandoProducto()
        {
            Console.Clear();
            Listas listas = new Listas();
            Console.WriteLine("Modificando Producto...");

            Console.Write("Digite el  codigo: ");
            Codigo = Console.ReadLine();
            Console.WriteLine(Codigo);



        }
        public void EliminandoProducto()
        {
            Console.Clear();
            Listas listas = new Listas();
            Console.WriteLine("Eliminando Producto...");

            Console.Write("Digite el codigo: ");
            Codigo = Console.ReadLine();

            Console.WriteLine(Codigo);

        }
    }
}
