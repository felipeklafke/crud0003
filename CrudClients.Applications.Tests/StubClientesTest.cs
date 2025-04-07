namespace CrudClients.Applications.Tests;

public sealed class StubClientesTest : IClientes
{
    private IEnumerable<Cliente> _clientes { get; set; }

    public StubClientesTest()
    {
        this._clientes = [new Cliente { IdUnicoParaExemplo = 1 }];
    }

    public IEnumerable<Cliente> Obter(Cliente cliente)
    {
        return this._clientes;
    }

    public void CadastrarAlteracoes(Cliente cliente)
    {
        this._clientes.Append(cliente);
    }

    public void Remover(Cliente cliente)
    {
        this._clientes = this._clientes.Where(w => w.IdUnicoParaExemplo != cliente.IdUnicoParaExemplo);
    }

    // public void CadastrarAlteracoes(Cliente cliente)
    // {
    //     this._clientes.Append(cliente);
    // }

    // public IEnumerable<Cliente> Obter(Cliente clientesFiltros)
    // {
    //     return this._clientes.Where(w => w.IdUnicoParaExemplo == clientesFiltros.IdUnicoParaExemplo);
    // }

    // public void Remover(Cliente clientes)
    // {
    //     this._clientes = this._clientes.Where(w => w.IdUnicoParaExemplo != clientes.IdUnicoParaExemplo);
    // }


    // public IEnumerable<Cliente> Obter()
    // {
    //     return this._clientes;
    // }
}