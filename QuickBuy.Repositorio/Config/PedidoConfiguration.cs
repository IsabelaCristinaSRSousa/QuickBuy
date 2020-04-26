using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Config
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(pd => pd.Id);

            builder
                .Property(pd => pd.DataPedido)
                .IsRequired();           

            builder
                .Property(pd => pd.DataPrevisaoEntrega)
                .IsRequired();
            builder
                .Property(pd => pd.Cep)
                .IsRequired()
                .HasMaxLength(10);

            builder
                .Property(pd => pd.Estado)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(pd => pd.EnderecoCompleto)
                .IsRequired()
                .HasMaxLength(200);

            builder
                .Property(pd => pd.NumeroEndereco)
                .IsRequired();

            builder.HasOne(p => p.Usuario);
            


                
        }
    }
}
