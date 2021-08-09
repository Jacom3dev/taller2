using System;

namespace taller
{
    class Program
    {
        
        static void Main(string[] args)
        {
            bool configuration = false;
            Configuracion conf = new();
            ModuloCliente moduloCliente = new();
            ModuloProducto moduloProducto =new ();
            Configuracion configuracion = new();
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
                        
                        if (configuration)
                        {
                            Console.Clear();
                            conf.MostrarNombre();
                            moduloCliente.Clientes();
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
                            conf.MostrarNombre();
                            moduloProducto.Productos();
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
                        configuration = true;
                        configuracion.PerdirNombre();
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
