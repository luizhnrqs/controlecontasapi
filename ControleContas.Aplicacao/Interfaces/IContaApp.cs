﻿using ControleContas.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleContas.Aplicacao.Interfaces
{
    public interface IContaApp : IBaseApp<Conta>
    {
        Conta BuscarPorNumeroConta(int numeroConta);
        void Transferir(string numContaOrigem, string numContaDestino, double valor);
    }
}
