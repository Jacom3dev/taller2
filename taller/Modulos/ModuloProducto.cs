using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using taller.Funciones;

namespace taller
{
    class ModuloProducto
    {
        public void Productos()
        {
            FuncionesProductos funcionesProductos = new();
            bool salir = true;
            byte Opcion;


            while (salir)
            {
                Console.WriteLine("....................\n" +
                              "1)\t Crear Producto\n" +
                              "2)\t Buscar Producto\n" +
                              "3)\t Modificar Producto\n" +
                              "4)\t Eliminar Producto\n" +
                              "5)\t salir\n" +
                              "....................");
                Console.Write("Elija la opcion requerida: ");
                Opcion = byte.Parse(Console.ReadLine());

                switch (Opcion)
                {
                    case 1:
                        funcionesProductos.CreandoProdcuto();
                        break;
                    case 2:
                        funcionesProductos.BuscandoProducto();
                        break;
                    case 3:
                        funcionesProductos.ModificandoProducto();
                        break;
                    case 4:
                        funcionesProductos.EliminandoProducto();
                        break;
                    case 5:
                        Console.Clear();
                        salir = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opcion no valida");
                        break;
                }

            }


        }
    }
}
