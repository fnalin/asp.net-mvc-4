using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var _proxy = new Clientes.ClientesClient())
            {
                var clientes = _proxy.Todos();
                foreach (var cli in clientes)
                {
                    Console.WriteLine("Id: {0} | Nome: {1}", cli.Id, cli.Nome);
                }
            }

            Console.ReadLine();
        }
    }
}
