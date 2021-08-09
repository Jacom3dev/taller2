using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using taller.Funciones;

namespace taller
{
    class ModuloCliente
    {
        
        public void Clientes()
        {
            FuncionesClientes funcionesClientes = new();
            bool salir = true;
            byte Opcion;
           
            while (salir)
            {
                Console.WriteLine("....................\n" +
                              "1)\t Crear Clientes\n" +
                              "2)\t Buscar Cliente\n" +
                              "3)\t Modificar Cliente\n" +
                              "4)\t Eliminar Cliente\n" +
                              "5)\t salir\n" +
                              "....................");
                Console.Write("Elija la opcion requerida: ");
                Opcion = byte.Parse(Console.ReadLine());

                switch (Opcion)
                {
                    case 1:
                        funcionesClientes.CreandoCliente();
                        break;
                    case 2:
                        funcionesClientes.BuscandoCliente();
                        break;
                    case 3:
                        funcionesClientes.ModificandoCliente();
                        break;
                    case 4:
                        funcionesClientes.EliminandoCliente();
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
