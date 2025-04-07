
namespace CrudClients.Applications.Tests;

public class ClientesTest
{
    [Fact(DisplayName = "Testa com banco em memória - adicao validando cnpj")]
    public void CadastrarAlteracoesValidacaoDocumentoCnpj()
    {
        IClientes clientes = new StubClientesTest();

        Cliente cliente = new()
        {
            IdUnicoParaExemplo = 1,
            Documento = new Cnpj(),

        };
        clientes.CadastrarAlteracoes(cliente);

        var expectedId = 1;

        CnpjInscricaoEstadualValidator validator = new();

        Assert.True(clientes.Obter(cliente).Any(a => a.IdUnicoParaExemplo == expectedId));
        Assert.False(validator.Validate(cliente).IsValid);

    }

    [Fact(DisplayName = "Testa com banco em memória - adicao validando cpf")]
    public void CadastrarAlteracoesValidacaoDocumentoCpf()
    {
        IClientes clientes = new StubClientesTest();

        Cliente cliente = new()
        {
            IdUnicoParaExemplo = 1,
            Documento = new Cnpj("11122233344"),
            ClienteDataNascimento = new DataNascimento(new DateOnly(2023, 02, 27)),
            Cidade = new Cidade("cidade")
        };
        clientes.CadastrarAlteracoes(cliente);

        var expectedId = 1;

        CpfIadadeMinimaValidator validator = new();

        Assert.True(clientes.Obter(cliente).Any(a => a.IdUnicoParaExemplo == expectedId));
        Assert.False(validator.Validate(cliente).IsValid);
    }

    [Fact(DisplayName = "Testa com banco em memória - remocao")]
    public void Remover()
    {

        IClientes clientes = new StubClientesTest();

        Cliente cliente = new()
        {
            IdUnicoParaExemplo = 1

        };

        clientes.CadastrarAlteracoes(cliente);

        Assert.True(clientes.Obter(cliente).Any(a => a.IdUnicoParaExemplo == 1));

        clientes.Remover(cliente);

        var expected = false;

        Assert.True(clientes.Obter(cliente).Count() == 0);
    }
}