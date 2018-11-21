using ControleContas.Aplicacao.Interfaces;
using ControleContas.Data.Contextos.Interfaces;
using ControleContas.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleContas.Aplicacao
{
    public class AgenciaApp : BaseApp<Agencia>, IAgenciaApp
    {
        private readonly IAgenciaRepositorio _repositorio;

        public AgenciaApp(IUnitOfWork unit, IAgenciaRepositorio repositorio)
            : base(repositorio, unit)
        {
            _repositorio = repositorio;
        }
    }
}
