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
    public class TipoContaApp : BaseApp<TipoConta>, ITipoContaApp
    {
        private readonly ITipoContaRepositorio _repositorio;

        public TipoContaApp(IUnitOfWork unit, ITipoContaRepositorio repositorio)
            : base(repositorio, unit)
        {
            _repositorio = repositorio;
        }
    }
}
