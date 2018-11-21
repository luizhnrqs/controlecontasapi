using ControleContas.Data.Contextos.Interfaces;
using ControleContas.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleContas.Data.Contextos.Repositorios
{
    public class TipoContaRepositorio : RepositorioBase<TipoConta>, ITipoContaRepositorio
    {
        private readonly IUnitOfWork _unit;

        public TipoContaRepositorio(IUnitOfWork unit)
            : base(unit)
        {
            _unit = unit;
        }

        public TipoConta BuscarTipoContaPorNome(string nome)
        {
            return _unit.Contexto.Set<TipoConta>().Where(x => x.NomeTipoConta == nome).FirstOrDefault();
        }
    }
}
