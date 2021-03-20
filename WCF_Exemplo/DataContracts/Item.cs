using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCF_Exemplo.DataContracts
{
    [DataContract]
    public class Item
    {
        [DataMember]
        public int CodigoBarra;

        [DataMember]
        public Produto Produto;

        public static implicit operator Item(Database.Item item)
        {
            return new Item
            {
                CodigoBarra = item.codigo,
                Produto = item.Produto
            };
        }
    }
}