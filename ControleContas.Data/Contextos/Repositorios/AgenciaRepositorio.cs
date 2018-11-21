﻿using ControleContas.Data.Contextos.Interfaces;
using ControleContas.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleContas.Data.Contextos.Repositorios
{
    public class AgenciaRepositorio : RepositorioBase<Agencia>, IAgenciaRepositorio
    {
        private readonly IUnitOfWork _unit;

        public AgenciaRepositorio(IUnitOfWork unit)
            : base(unit)
        {
            _unit = unit;
        }

        public IEnumerable<Agencia> BuscarAgenciaPorNome(string nome)
        {
            return _unit.Contexto.Set<Agencia>().Where(x => x.NomeAgencia == nome);
        }
    }
}
