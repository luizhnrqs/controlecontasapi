﻿using ControleContas.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace ControleContas.Data.Contextos
{
    public class ContaMap : EntityTypeConfiguration<Conta>
    {
        public ContaMap()
        {
            HasKey(x => x.IdConta);

            Property(x => x.IdAgencia)
                .IsRequired();

            Property(x => x.IdConta)
                .IsRequired();

            Property(x => x.IdTipoConta)
                .IsRequired();

            Property(x => x.NumeroConta)
                .IsRequired();

            Property(x => x.Saldo)
                .IsRequired();

            HasRequired(x => x.Cliente)
                .WithMany()
                .HasForeignKey(x => x.IdCliente);

            HasRequired(x => x.Agencia)
                .WithMany()
                .HasForeignKey(x => x.IdAgencia);

            HasRequired(x => x.TipoConta)
                .WithMany()
                .HasForeignKey(x => x.IdTipoConta);
        }
    }
}