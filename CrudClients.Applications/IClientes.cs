namespace CrudClients.Applications;


public interface IClientes
{

    public IEnumerable<Cliente> Obter(Cliente cliente);
    public void CadastrarAlteracoes(Cliente cliente);
    public void Remover(Cliente cliente);
}