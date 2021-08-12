using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using taller.Modelo;

namespace taller.Servicios
{
    public class ServicioCliente
    {
        private List<Cliente> listaClientes = new();
        public void AgregarCliente(Cliente cliente)
        {
            bool existe = false;
            var consulta = (from item in listaClientes select item).ToList();

            if (consulta.Count==0)
            {
                listaClientes.Add(cliente);
            }
            else
            {
                foreach (var item in consulta)
                {
                    if (cliente.Codigo != item.Codigo)
                    {
                        listaClientes.Add(cliente);
                        existe = true;
                    }
                }
                if (!existe)
                {
                    Console.WriteLine("El usuario ya existe");
                }
            }

           


            
        }
        public void EliminarCliente(string Cedula)
        {
            
        }
        public void ListarClientes()
        {
            foreach (var item in listaClientes)
            { 
                Console.WriteLine(item.Nombre);
            }
        }

    }
}
