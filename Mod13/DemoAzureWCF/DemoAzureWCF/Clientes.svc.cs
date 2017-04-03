using DemoAzureWCF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DemoAzureWCF
{
    public class Clientes : IClientes
    {
        private readonly IEnumerable<Cliente> _data =
            new List<Cliente> { 
                new Cliente{Id=1, Nome="Fabiano"},
                new Cliente{Id=2, Nome="Priscila"},
                new Cliente{Id=3, Nome="Raphael"},
                new Cliente{Id=4, Nome="José Carlos"},
            };
        public IEnumerable<Cliente> Todos()
        {
            return _data;
        }

        public Cliente ObterPorId(string id)
        {
            return _data.FirstOrDefault(c => c.Id == Convert.ToInt32(id));
        }
    }
}
