using System;
using taller.Modelo;
using taller.Servicios;
using taller.Menu;
namespace taller
{
    class Program
    {
        
        static void Main(string[] args)
        {
            MenuOpciones menuOpciones = new();
            ServicioCliente _servicioCliente = new();
          
            byte Opcion;
            bool salir = true;
            while (salir)
            {
                menuOpciones.MenuPrincipal();
                Console.Write("Elija la opcion requerida: ");
                Opcion = byte.Parse(Console.ReadLine());

                switch (Opcion)
                {
                    case 1:
                        Cliente cliente = new();
                        Console.Clear();
                        menuOpciones.MenuCliente();
                        int opcion = int.Parse(Console.ReadLine());

                        switch (opcion)
                        {
                            case 1:
                                Console.WriteLine("Crear Cliente");
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

                       
                        break;
                    case 2:
                        
                        
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
