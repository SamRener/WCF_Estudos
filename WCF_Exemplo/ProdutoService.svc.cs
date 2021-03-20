using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WCF_Exemplo.Database;
using Produto = WCF_Exemplo.DataContracts.Produto;

namespace WCF_Exemplo
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "Service1" no arquivo de código, svc e configuração ao mesmo tempo.
    // OBSERVAÇÃO: Para iniciar o cliente de teste do WCF para testar esse serviço, selecione Service1.svc ou Service1.svc.cs no Gerenciador de Soluções e inicie a depuração.
    public class ProdutoService : IProdutoService
    {
        public bool Create(string nome, string marca, decimal preco, ref string mensagem)
        {
            try
            {
                CaixaModel ctx = new CaixaModel();
                ctx.Produto.Add(new Database.Produto
                {
                    nome = nome,
                    marca = marca,
                    precoBase = preco
                });

                ctx.SaveChanges();
                
                mensagem = "Produto Inserido com Sucesso!";

                return true;
            }catch(Exception ex)
            {
                mensagem = ex.ToString();
                return false;
            }
        }

        public bool Delete(int id, ref string mensagem)
        {
            try
            {
                CaixaModel ctx = new CaixaModel();
                ctx.Produto.Remove(ctx.Produto.Single(x => x.id == id));

                ctx.SaveChanges();
                
                mensagem = "Produto removido com Sucesso!";

                return true;
            }catch(Exception ex)
            {
                mensagem = ex.ToString();
                return false;
            }
        }

        public bool Edit(Produto produto, ref string mensagem)
        {
            try
            {
                CaixaModel ctx = new CaixaModel();
                var obj = ctx.Produto.Single(x => x.id == produto.Id);

                obj.marca = produto.Marca;
                obj.nome = produto.Nome;
                obj.precoBase = produto.Preco;

                ctx.SaveChanges();

                mensagem = "Produto editado com Sucesso!";

                return true;
            }
            catch (Exception ex)
            {
                mensagem = ex.ToString();
                return false;
            }
        }

        public IEnumerable<Produto> Find(ref string mensagem)
        {
            try
            {
                CaixaModel ctx = new CaixaModel();
                var objs = ctx.Produto.ToList();
                IEnumerable<Produto> retorno = new List<Produto>();

                objs.ForEach(x => ((List<Produto>)retorno).Add(x));

                return retorno;
            }
            catch (Exception ex)
            {
                mensagem = ex.ToString();
                return null;
            }
        }

        public Produto Get(int id, ref string mensagem)
        {
            try
            {
                CaixaModel ctx = new CaixaModel();
                var obj = ctx.Produto.Single(x => x.id == id);


                return obj;
            }
            catch (Exception ex)
            {
                mensagem = ex.ToString();
                return null;
            }
        }
    }
}
