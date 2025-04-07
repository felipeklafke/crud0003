namespace CrudClients.Applications;

public class Cliente
{
    // apenas para exemplo
    public short IdUnicoParaExemplo { get; set; }
    public IDocumento Documento { get; set; }
    public Nome ClienteNome { get; set; }
    public DataNascimento ClienteDataNascimento { get; set; }
    // public Cpf IdUnicoParaExemplo { get; set; }
    // public Cnpj CLienteCnpj { get; set; }
    public Email ContatoEmail { get; set; }
    public Telefone ContatoTelefone { get; set; }
    public RazaoSocial RazaoSocial { get; set; }
    public Endereco Endereco { get; set; }
    public Cep Cep { get; set; }
    public Numero Numero { get; set; }
    public Bairro Bairro { get; set; }
    public Cidade Cidade { get; set; }
    public Estado Estado { get; set; }
    public InscricaoEstadual Ie { get; set; }

}