using ControleContas.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleContas.Data.Contextos.Interfaces
{
    public interface IClienteRepositorio : IRepositorioBase<Cliente>
    {
        IEnumerable<Cliente> BuscarClientePorNome(string nome);
        Cliente BuscarClientePorCPF(string CPF);
        Cliente BuscarClientePorEmail(string email);
    }
}
