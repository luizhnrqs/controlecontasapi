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
    public class ClienteApp : BaseApp<Cliente>, IClienteApp
    {
        private readonly IClienteRepositorio _repositorio;

        public ClienteApp(IUnitOfWork unit, IClienteRepositorio repositorio)
            : base(repositorio, unit)
        {
            _repositorio = repositorio;
        }
    }
}
