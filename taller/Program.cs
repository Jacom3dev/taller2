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
            string NombreEmpresa = null;
            MenuOpciones menuOpciones = new();
            ServicioCliente _servicioCliente = new();
            ServicioProducto _servicioProducto = new();
          
            byte Opcion;
            bool salir = true;
            while (salir)
            {
                if (NombreEmpresa != null)
                {
                    Console.WriteLine($"Bienvenidos a {NombreEmpresa}");
                }
                menuOpciones.MenuPrincipal();
                Console.Write("Elija la opcion requerida: ");
                Opcion = byte.Parse(Console.ReadLine());
                
                
                switch (Opcion)
                {
                    case 1:
                        Cliente cliente = new();
                        Console.Clear();
                        bool salir2 = true;
                       
                        while (salir2)
                        {
                            if (NombreEmpresa != null)
                            {
                                Console.WriteLine($"Bienvenidos a {NombreEmpresa}");
                            }
                            menuOpciones.MenuCliente();
                            Console.Write("Elija la opcion requerida: ");
                            int opcion = int.Parse(Console.ReadLine());
                            switch (opcion)
                            {
                                case 1:
                                    Console.Clear();
                                    Console.WriteLine("Crear Cliente");
                                    Console.Write("Nombre: ");
                                    string Nombre = Console.ReadLine();
                                    Console.Write("cedula: ");
                                    string Codigo = Console.ReadLine();
                                    Console.Write("telefono: ");
                                    string Telefono = Console.ReadLine();
                                    Console.Write("dirreccion: ");
                                    string Dirrecion = Console.ReadLine();

                                    _servicioCliente.AgregarCliente(new Cliente()
                                    {
                                        Nombre = Nombre,
                                        Codigo = Codigo,
                                        Telefono = Telefono,
                                        Dirrecion = Dirrecion
                                    }
                                    );
                                    break;
                                case 2:
                                    Console.Clear();
                                    Console.WriteLine("Buscar Cliente");
                                    Console.Write("Numero de cedula: ");
                                     string codigoBuscar = Console.ReadLine();
                                    _servicioCliente.BuscarCliente(codigoBuscar);
                                    break;
                                case 3:
                                    Console.Clear();
                                    Console.WriteLine("Eliminar Cliente");
                                    Console.Write("Digite el numero de cedula: ");
                                    string CodigoEliminar = Console.ReadLine();

                                    _servicioCliente.EliminarCliente(CodigoEliminar);
                                    break;
                                case 4:
                                    Console.Clear();
                                    Console.WriteLine("Editar Cliente");
                                    Console.Write("Numero de cedula: ");
                                    string codigoEditar = Console.ReadLine();

                                    if (codigoEditar != "")
                                    {
                                        Console.Write("Nombre: ");
                                        string nombre = Console.ReadLine();
                                        Console.Write("cedula: ");
                                        string codigo = Console.ReadLine();
                                        Console.Write("telefono: ");
                                        string telefono = Console.ReadLine();
                                        Console.Write("dirreccion: ");
                                        string dirrecion = Console.ReadLine();
                                        _servicioCliente.ModificarCliente(codigoEditar, new Cliente()
                                        {
                                            Nombre = nombre,
                                            Codigo = codigo,
                                            Telefono = telefono,
                                            Dirrecion = dirrecion
                                        }
                                        );


                                    }
                                    else
                                    {
                                        Console.WriteLine("Digita el numero de cedula");
                                    }

                                    break;
                                case 5:
                                    salir2 = false;
                                    Console.Clear();
                                    break;
                                default:
                                    Console.Clear();
                                    Console.WriteLine("Opcion no valida");
                                    break;
                            }
               

                        }

                        break;
                    case 2:
                        Producto producto = new();
                        Console.Clear();
                        bool salir3 = true;

                        while (salir3)
                        {
                            if (NombreEmpresa != null)
                            {
                                Console.WriteLine($"Bienvenidos a {NombreEmpresa}");
                            }
                            menuOpciones.MenuProducto();
                            Console.Write("Elija la opcion requerida: ");
                            int opcion = int.Parse(Console.ReadLine());
                            switch (opcion)
                            {
                                case 1:
                                    Console.Clear();
                                    Console.WriteLine("Crear Producto");
                                    Console.Write("Nombre: ");
                                    string Nombre = Console.ReadLine();
                                    Console.Write("precio: ");
                                    int precio = int.Parse(Console.ReadLine());
                                    Console.Write("cantidad: ");
                                    int cantidad =int.Parse(Console.ReadLine());
                                    Console.Write("codigo: ");
                                    string codigo = Console.ReadLine();

                                    _servicioProducto.AgregarProducto(new Producto()
                                        {
                                            Nombre = Nombre,
                                            Precio = precio,
                                            Cantidad = cantidad,
                                            Codigo = codigo
                                        }
                                    );
                                    break;
                                case 2:
                                    Console.Clear();
                                    Console.WriteLine("Buscar producto");
                                    Console.Write("codigo producto: ");
                                    string codigoBuscar = Console.ReadLine();
                                    _servicioProducto.BuscarProducto(codigoBuscar);
                                    break;
                                case 3:
                                    Console.Clear();
                                    Console.WriteLine("Eliminar producto");
                                    Console.Write("codigo producto: ");
                                    string CodigoEliminar = Console.ReadLine();
                                    _servicioProducto.EliminarProducto(CodigoEliminar);
                                    break;
                                case 4:
                                    Console.Clear();
                                    Console.WriteLine("Editar Producto");
                                    Console.Write("codigo producto: ");
                                    string codigoEditar = Console.ReadLine();

                                    if (codigoEditar != "")
                                    {
                                        Console.Write("Nombre: ");
                                        string nombre = Console.ReadLine();
                                        Console.Write("precio: ");
                                        int Precio = int.Parse(Console.ReadLine());
                                        Console.Write("cantidad: ");
                                        int Cantidad = int.Parse(Console.ReadLine());
                                        Console.Write("codigo: ");
                                        string Codigo = Console.ReadLine();
                                        _servicioProducto.ModificarProducto(codigoEditar, new Producto()
                                        {
                                            Nombre = nombre,
                                            Precio = Precio,
                                            Cantidad = Cantidad,
                                            Codigo = Codigo
                                        }
                                        );


                                    }
                                    else
                                    {
                                        Console.WriteLine("Digita el codigo");
                                    }


                                    break;
                                case 5:
                                    salir3 = false;
                                    Console.Clear();
                                    break;
                                default:
                                    Console.Clear();
                                    Console.WriteLine("Opcion no valida");
                                    break;
                            }
                        }

                        break;
                    case 3:

                        break;
                    case 4:
                        Console.Clear();
                        bool salir4 = true;
                        while (salir4)
                        {
                            if (NombreEmpresa != null)
                            {
                                Console.WriteLine($"Bienvenidos a {NombreEmpresa}");
                            }
                            menuOpciones.MenuReportes();
                            Console.Write("Elija la opcion requerida: ");
                            int opcion = int.Parse(Console.ReadLine());
                            switch (opcion)
                            {
                                case 1:
                                    Console.Clear();
                                    Console.WriteLine("........ Clientes ........");
                                    _servicioCliente.ListarClientes();
                                    break;
                                case 2:
                                    Console.Clear();
                                    Console.WriteLine("........ Productos ........");
                                    _servicioProducto.ListarProductos();
                                    break;
                                case 3:
                                    break;
                                case 4:
                                    salir4 = false;
                                    Console.Clear();
                                    break;
                                    
                                default:
                                    Console.Clear();
                                    Console.WriteLine("Opcion no valida");
                                    break;
                            }
                        }
                        break;
                    case 5:
                        Console.WriteLine("------ Configuracion ------");
                        Console.Write("Digite el nombre de la empresa: ");
                        NombreEmpresa = Console.ReadLine();
                        Console.Write("si o no: ");
                        string respuesta = Console.ReadLine();
                        if (respuesta.Equals("si"))
                        {
                            _servicioCliente.DiezClientes();
                            _servicioProducto.DiezProductos();
                        }
                        Console.Clear();
                        break;
                    case 6:
                        salir = false;
                        Console.Clear();
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Opcion incorrecta");
                        break;
                }

            }
        }
    }
}
