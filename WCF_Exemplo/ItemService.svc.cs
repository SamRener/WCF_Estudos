using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCF_Exemplo.Database;

namespace WCF_Exemplo
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "ItemService" no arquivo de código, svc e configuração ao mesmo tempo.
    // OBSERVAÇÃO: Para iniciar o cliente de teste do WCF para testar esse serviço, selecione ItemService.svc ou ItemService.svc.cs no Gerenciador de Soluções e inicie a depuração.
    public class ItemService : IItemService
    {
        public bool Add(int codigoBarras, int IdProduto, ref string mensagem)
        {
            try
            {
                CaixaModel ctx = new CaixaModel();
                ctx.Item.Add(new Item { codigo = codigoBarras, idProduto = IdProduto });
                ctx.SaveChanges();

                mensagem = "Item inserido com sucesso";
                return true;
            }
            catch(Exception ex)
            {
                mensagem = ex.ToString();
                return false;
            }
        }


        public DataContracts.Produto Get(int codigoBarras, ref string mensagem)
        {
            try
            {
                CaixaModel ctx = new CaixaModel();

                return ctx.Item.Single(x => x.codigo == codigoBarras).Produto;
            }
            catch (Exception ex)
            {
                mensagem = ex.ToString();
                return null;
            }
        }

        public bool Pass(int codigoBarras, ref string mensagem)
        {
            try
            {
                CaixaModel ctx = new CaixaModel();
                ctx.Item.Remove(ctx.Item.Single(x => x.codigo == codigoBarras));
                ctx.SaveChanges();

                mensagem = "Produto pago com sucesso";
                return true;
            }
            catch (Exception ex)
            {
                mensagem = ex.ToString();
                return false;
            }
        }

        List<DataContracts.Item> IItemService.Find(int IdProduto, ref string mensagem)
        {
            try
            {
                CaixaModel ctx = new CaixaModel();
                List<DataContracts.Item> retorno = new List<DataContracts.Item>();
                List<Item> databaseObjects = ctx.Item.Where(x => x.Produto.id == IdProduto).ToList();

                databaseObjects.ForEach(x => retorno.Add(x));
                return retorno;
            }
            catch (Exception ex)
            {
                mensagem = ex.ToString();
                return null;
            }
        }
    }
}
