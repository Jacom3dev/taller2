using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taller.Menu
{
    public class MenuOpciones
    {
        public void MenuPrincipal()
        {
            Console.WriteLine("....................\n" +
                             "1)\t Clientes\n" +
                             "2)\t Productos\n" +
                             "3)\t Ventas\n" +
                             "4)\t Reportes\n" +
                             "5)\t Configuracion\n" +
                             "6)\t salir\n" +
                             "....................");
        }
        public void MenuCliente()
        {

            Console.WriteLine("....................\n" +
                  "1)\t Crear cliente\n" +
                  "2)\t Buscar cliente\n" +
                  "3)\t Eliminar cliente\n" +
                  "4)\t Modificar cliente\n" +
                  "5)\t salir\n" +
                  "....................");
        }

        public void MenuProducto()
        {
            Console.WriteLine("....................\n" +
                             "1)\t Crear Producto\n" +
                             "2)\t Buscar Producto\n" +
                             "3)\t Eliminar Producto\n" +
                             "4)\t Modificar Producto\n" +
                             "5)\t salir\n" +
                             "....................");
        }
        public void MenuReportes()
        {
            Console.WriteLine("....................\n" +
                             "1)\t Listar Clientes\n" +
                             "2)\t listar productos\n" +
                             "3)\t listar Facturas\n" +
                             "4)\t salir\n" +
                             "....................");
        }
    }
}
