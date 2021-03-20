using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCF_Exemplo.DataContracts
{
    [DataContract]
    public class Produto
    {
        [DataMember]
        public int Id;

        [DataMember]
        public string Nome;

        [DataMember]
        public string Marca;

        [DataMember]
        public decimal Preco;

        public static implicit operator Produto(Database.Produto obj)
        {
            return new Produto
            {
                Id = obj.id,
                Marca = obj.marca,
                Nome = obj.nome,
                Preco = obj.precoBase
            };
        }
    }
}