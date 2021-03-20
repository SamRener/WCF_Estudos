using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WCF_Exemplo.DataContracts;

namespace WCF_Exemplo
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da interface "IService1" no arquivo de código e configuração ao mesmo tempo.
    [ServiceContract]
    public interface IProdutoService
    {

        [OperationContract]
        bool Create(string nome, string marca, decimal preco, ref string mensagem);

        [OperationContract]
        bool Edit(Produto produto, ref string mensagem);

        [OperationContract]
        bool Delete(int id, ref string mensagem);

        [OperationContract]
        Produto Get(int id, ref string mensagem);

        [OperationContract]
        IEnumerable<Produto> Find(ref string mensagem);
    }


}
