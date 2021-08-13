using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using taller.Modelo;

namespace taller.Servicios
{
    class ServicioProducto
    {
        private List<Producto> listaProductos = new();
        public void AgregarProducto(Producto producto)
        {
            bool existe = false;

            var consulta = (from item in listaProductos select item).ToList();

            if (consulta.Count == 0)
            {
                listaProductos.Add(producto);
            }
            else
            {
                foreach (var item in consulta)
                {
                    if (producto.Codigo != item.Codigo)
                    {
                        existe = true;
                    }
                }
                if (existe)
                {
                    listaProductos.Add(producto);
                }
                else
                {
                    Console.WriteLine("El producto ya existe");
                }
            }

        }
        public void BuscarProducto(string codigo)
        {
            bool existe = false;
            var consulta = (from item in listaProductos select item).ToList();

            if (consulta.Count == 0)
            {
                Console.WriteLine("no hay productos");
            }
            else
            {
                foreach (var item in consulta.Select((value, posicion) => new { value, posicion }))
                {
                    if (codigo == item.value.Codigo)
                    {
                        Console.WriteLine($"{item.value.Nombre} {item.value.Precio} {item.value.Cantidad} {item.value.Codigo}");
                        existe = true;
                    }
                }
                if (!existe)
                {
                    Console.WriteLine("El producto  no existe ");
                }
            }
        }
        public void EliminarProducto(string codigo)
        {
            bool existe = false;
            var consulta = (from item in listaProductos select item).ToList();

            if (consulta.Count == 0)
            {
                Console.WriteLine("no hay productos");
            }
            else
            {
                foreach (var item in consulta.Select((value, posicion) => new { value, posicion }))
                {
                    if (codigo == item.value.Codigo)
                    {
                        listaProductos.RemoveAt(item.posicion);
                        existe = true;
                    }
                }
                if (!existe)
                {
                    Console.WriteLine("El producto  no existe ");
                }
            }
        }

        public void ModificarProducto()
        {

        }

        public void ListarProductos()
        {
            if (listaProductos.Count == 0)
            {
                Console.WriteLine("NO Hay Productos");
            }
            else
            {
                foreach (var item in listaProductos)
                {
                    Console.WriteLine($"PRODUCTO: {item.Nombre}   PRECIO: {item.Precio}  CANTIDAD: {item.Cantidad}  CODIGO: {item.Codigo}");
                }
            }
           
        }
    }
}
