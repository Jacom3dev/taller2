using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using taller.Propiedades;

namespace taller
{
    class Listas
    {
       public List<PropiedadesClientes> ListaClientes = new()
       {
            new PropiedadesClientes()
            {
                Nombre = "jose julian",
                Telefono = "3152232388",
                Dirrecion ="cr99",
                Codigo = "1005441399"
                
            },
           new PropiedadesClientes()
           {
               Nombre = "ali alexander",
               Telefono = "3152232388",
               Dirrecion = "cr89 a10",
               Codigo = "1737475893"

           },
          
       };
        

       public List<PropiedadesProductos> ListaProdcutos = new()
       {
            new PropiedadesProductos()
            {
                Nombre = "Zapato",
                Precio = 150000,
                Cantidad = 20,
                Codigo = "1",
            },
           new PropiedadesProductos()
           {
               Nombre = "Camisa",
               Precio = 70000,
               Cantidad = 10,
               Codigo = "2",
           }
       };
    }
}
