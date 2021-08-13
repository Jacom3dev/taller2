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
                        existe = true;
                    }
                }
                if (existe)
                {
                    listaClientes.Add(cliente);
                }
                else
                {
                    Console.WriteLine("El usuario ya existe");
                }
            }
            
        }
        public void BuscarCliente(string cedula)
        {
            bool existe = false;
            var consulta = (from item in listaClientes select item).ToList();

            if (consulta.Count == 0)
            {
                Console.WriteLine("no hay clientes");
            }
            else
            {
                foreach (var item in consulta.Select((value, posicion) => new { value, posicion }))
                {
                    if (cedula == item.value.Codigo)
                    {
                        Console.WriteLine($"{item.value.Nombre} {item.value.Codigo} {item.value.Dirrecion} {item.value.Telefono}");
                        existe = true;
                    }
                }
                if (!existe)
                {
                    Console.WriteLine("El usuario  no existe ");
                }
            }
        }
        public void EliminarCliente(string cedula)
        {
            bool existe = false;
            var consulta = (from item in listaClientes select item).ToList();

            if (consulta.Count == 0)
            {
                Console.WriteLine("no hay clientes");
            }
            else
            {
                foreach (var item in consulta.Select((value,posicion)=> new {value,posicion}))
                {
                    if (cedula == item.value.Codigo)
                    {
                        listaClientes.RemoveAt(item.posicion);
                        existe = true;
                    }
                }
                if (!existe)
                {
                    Console.WriteLine("El usuario  no existe ");
                }
            }
        }

        public void ModificarCliente(string codigoEditar, Cliente modificar)
        {
            bool existe = false;
            foreach (var item in listaClientes)
            {
                if (item.Codigo == codigoEditar)
                {
                    existe = true;

                    item.Nombre = modificar.Nombre;
                    item.Codigo = modificar.Codigo;
                    item.Dirrecion = modificar.Dirrecion;
                    item.Telefono = modificar.Telefono;

                }

            }
            if (!existe)
            {
                Console.WriteLine("El Cliente no existe");
            }

        }

        public void ListarClientes()
        {
            if (listaClientes.Count == 0)
            {
                Console.WriteLine("No Hay Clientes");
            }
            else
            {
                foreach (var item in listaClientes)
                {
                    Console.WriteLine($"NOMBRE: {item.Nombre}   CEDULA: {item.Codigo}   DIRECCION: {item.Dirrecion}   TELEFONO: {item.Telefono}");
                }
            }
           
        }

        public void DiezClientes()
        {
            listaClientes.Add(new Cliente()
            {
                Nombre = "jose",
                Codigo = "1234",
                Telefono = "00000",
                Dirrecion = "cr99"

            }
            );
            listaClientes.Add(new Cliente()
            {
                Nombre = "julian",
                Codigo = "12345",
                Telefono = "00000",
                Dirrecion = "cr99"
            }
            );
            listaClientes.Add(new Cliente()
            {
                Nombre = "jacome",
                Codigo = "123456",
                Telefono = "00000",
                Dirrecion = "cr99"
            }
            );
            listaClientes.Add(new Cliente()
            {
                Nombre = "martinez",
                Codigo = "1234567",
                Telefono = "00000",
                Dirrecion = "cr99"
            }
           );
            listaClientes.Add(new Cliente()
            {
                Nombre = "camilo",
                Codigo = "12345678",
                Telefono = "00000",
                Dirrecion = "cr99"
            }
            );
            listaClientes.Add(new Cliente()
            {
                Nombre = "juan",
                Codigo = "123456789",
                Telefono = "00000",
                Dirrecion = "cr99"
            }
            );
            listaClientes.Add(new Cliente()
            {
                Nombre = "ali",
                Codigo = "98765",
                Telefono = "00000",
                Dirrecion = "cr99"
            }
            );
            listaClientes.Add(new Cliente()
            {
                Nombre = "rayo",
                Codigo = "987654",
                Telefono = "00000",
                Dirrecion = "cr99"
            }
            );
            listaClientes.Add(new Cliente()
            {
                Nombre = "mariana",
                Codigo = "9876543",
                Telefono = "00000",
                Dirrecion = "cr99"
            }
            );
            listaClientes.Add(new Cliente()
            {
                Nombre = "laura",
                Codigo = "987654321",
                Telefono = "00000",
                Dirrecion = "cr99"
            }
           );
        }

    }
}
