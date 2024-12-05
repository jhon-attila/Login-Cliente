using Login.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Login.Repository.Contract
{
    public interface IColaboradorRepository
    {

        Colaborador Login(string Email, string Senha);

        void Cadastrar(Colaborador colaborador);
        void Atualizar(Colaborador colaborador);
        void AtualizarSenha(Colaborador colaborador);
        void Excluir(int id);
        Colaborador ObterColaborador(int id);
        List<Colaborador> ObterColaboradorPorEmail();

        IEnumerable<Colaborador> ObterTodosColaboradores();
    }
}
