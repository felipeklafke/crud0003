
using FluentValidation;
using Microsoft.EntityFrameworkCore.InMemory.Storage.Internal;

namespace CrudClients.Applications;

public class CpfIadadeMinimaValidator : AbstractValidator<Cliente>
{
    public CpfIadadeMinimaValidator()
    {

        RuleFor(p => p)
            .NotEmpty()
            .When(p => p.Documento is Cpf)
            .Custom((pc, pd) =>
            {
                if ((DateTime.UtcNow.Year - pc.ClienteDataNascimento.Data.Year) < 18)
                {
                    pd.AddFailure("Idade minima 18 anos");
                }
            });

    }

}