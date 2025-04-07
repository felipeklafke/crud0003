using CrudClients.Applications;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

public class InscricaoEstadualConverter : ValueConverter<InscricaoEstadual, string>
{
    public InscricaoEstadualConverter() : base(
        dbValue => dbValue.ToString(),
        value => new InscricaoEstadual(value))
    {

    }
}