
using FluentValidation;

namespace CrudClients.Applications;

public class CnpjInscricaoEstadualValidator : AbstractValidator<Cliente>
{
    public CnpjInscricaoEstadualValidator()
    {
        RuleFor(p => p)
            .NotEmpty()
            .When(p => p.Documento is Cnpj)
            .Custom((pd, pc) =>
            {
                if (string.IsNullOrWhiteSpace(pd.Ie.Inscricao) && pd.Ie.Inscricao == new InscricaoEstadual().Inscricao)
                {
                    pc.AddFailure("Precisa cadastrar IE ou isencao");
                }
            });
    }

}