using DemoAzureWCF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace DemoAzureWCF
{
    [ServiceContract]
    public interface IClientes
    {
        [OperationContract]
        [WebGet(UriTemplate="clientes", ResponseFormat=WebMessageFormat.Json)]
        IEnumerable<Cliente> Todos();

        [OperationContract]
        [WebGet(UriTemplate="clientes/{id}", ResponseFormat=WebMessageFormat.Json)]
        Cliente ObterPorId(string id);
    }
}
