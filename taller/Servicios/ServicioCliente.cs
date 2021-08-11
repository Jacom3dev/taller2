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
        private List<Cliente> listaClientes { get; set; }
        public void AgregarCliente(Cliente cliente)
        {
            listaClientes.Add(cliente);
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
