using ControleContas.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace ControleContas.Data.Contextos
{
    public class AgenciaMap : EntityTypeConfiguration<Agencia>
    {
        public AgenciaMap()
        {
            HasKey(x => x.IdAgencia);

            Property(x => x.NomeAgencia)
                .IsRequired();
        }
    }
}