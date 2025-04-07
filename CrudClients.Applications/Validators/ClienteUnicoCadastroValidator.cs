
using FluentValidation;

namespace CrudClients.Applications;

public class ClienteUnicoCadastroValidator : AbstractValidator<Cliente>
{
    public ClienteUnicoCadastroValidator(IClientes clientes)
    {

        RuleFor(p => p.Documento)
            .NotEmpty()
            .When(p => clientes.Obter(p).Any(f => f.ContatoEmail == p.ContatoEmail || f.Documento.Identificacao == p.Documento.Identificacao))
            .WithMessage("Cadastro já existe")
            .WithName("Cadastro");

    }

}