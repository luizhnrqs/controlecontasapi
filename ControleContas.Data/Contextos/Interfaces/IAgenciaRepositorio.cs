using ControleContas.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleContas.Data.Contextos.Interfaces
{
    public interface IAgenciaRepositorio : IRepositorioBase<Agencia>
    {
        IEnumerable<Agencia> BuscarAgenciaPorNome(string nome);
    }
}
