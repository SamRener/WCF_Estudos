using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WCF_Exemplo.Database
{
    public partial class CaixaModel : DbContext
    {
        public CaixaModel()
            : base("name=CaixaContext")
        {
        }

        public virtual DbSet<Item> Item { get; set; }
        public virtual DbSet<Produto> Produto { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>()
                .Property(e => e.nome)
                .IsUnicode(false);

            modelBuilder.Entity<Produto>()
                .Property(e => e.marca)
                .IsUnicode(false);

            modelBuilder.Entity<Produto>()
                .Property(e => e.precoBase)
                .HasPrecision(9, 2);

            modelBuilder.Entity<Produto>()
                .HasMany(e => e.Item)
                .WithRequired(e => e.Produto)
                .HasForeignKey(e => e.idProduto)
                .WillCascadeOnDelete(false);
        }
    }
}
