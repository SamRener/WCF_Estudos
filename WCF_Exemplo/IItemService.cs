using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCF_Exemplo.DataContracts;

namespace WCF_Exemplo
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da interface "IItemService" no arquivo de código e configuração ao mesmo tempo.
    [ServiceContract]
    public interface IItemService
    {
        [OperationContract]
        bool Pass(int codigoBarras, ref string mensagem);

        [OperationContract]
        bool Add(int codigoBarras, int IdProduto, ref string mensagem);

        [OperationContract]
        Produto Get(int codigoBarras, ref string mensagem);


        [OperationContract]
        List<Item> Find(int IdProduto, ref string mensagem);
    }
}
