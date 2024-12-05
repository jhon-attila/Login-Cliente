using Login.Models;

namespace Login.Repository.Contract
{
    public interface IClienteRepositiry
    {

        Cliente Login(string Email, string Senha);

        void Cadastrar(Cliente cliente);
        void Atualizar(Cliente cliente);
        void Excluir(int id);
        void Desativar(int id);
        void Ativar(int id);
        Cliente ObterCliente(int id);

        IEnumerable<Cliente> ObterTodosClientes();
    }
}
