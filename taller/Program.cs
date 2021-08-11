using System;
using taller.Modelo;
using taller.Servicios;

namespace taller
{
    class Program
    {
        
        static void Main(string[] args)
        {
            ServicioCliente _servicioCliente = new();
            Cliente cliente = new();

            bool configuration = false;
          
            byte Opcion;
            bool salir = true;
            while (salir)
            {
                Console.WriteLine("....................\n" +
                              "1)\t Clientes\n" +
                              "2)\t Productos\n" +
                              "3)\t Ventas\n" +
                              "4)\t Reportes\n" +
                              "5)\t Configuracion\n" +
                              "6)\t salir\n" +
                              "....................");

                Console.Write("Elija la opcion requerida: ");
                Opcion = byte.Parse(Console.ReadLine());

                switch (Opcion)
                {
                    case 1:
                       

                        Console.WriteLine("1) crear cliente");
                        int opcion = int.Parse(Console.ReadLine());

                        switch (opcion)
                        {
                            case 1:
                                
                                Console.WriteLine("Nombre");
                                cliente.Nombre = Console.ReadLine();
                                Console.WriteLine("cedula");
                                cliente.Codigo  = Console.ReadLine();
                                Console.WriteLine("telefono");
                                cliente.Telefono = Console.ReadLine();
                                Console.WriteLine("dirreccion");
                                cliente.Dirrecion = Console.ReadLine();


                                _servicioCliente.AgregarCliente(cliente);
                                _servicioCliente.ListarClientes();

                                break;
                            default:
                                break;
                        }

                        if (configuration)
                        {
                            Console.Clear();
                           
                        }
                        else
                        {
                            Console.WriteLine("Entre al modulo configuracion  para agregar unos ajustes");
                        }
                       
                        break;
                    case 2:
                        
                        if (configuration)
                        {
                            Console.Clear();
                           
                        }
                        else
                        {
                            Console.WriteLine("Entre al modulo configuracion  para agregar unos ajustes");
                        }
                        
                        break;
                    case 3:
                        
                        break;
                    case 4:
                        break;
                    case 5:
                        Console.Clear();
                       
                        break;
                    case 6:
                        salir = false;
                        break;

                    default:
                        Console.WriteLine("Opcion incorrecta");
                        break;
                }
            }
        }
    }
}
