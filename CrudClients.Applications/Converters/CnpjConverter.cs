using CrudClients.Applications;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

public class CnpjConverter : ValueConverter<Cnpj, string>
{
    public CnpjConverter() : base(
        dbValue => dbValue.ToString(),
        value => new Cnpj(value))
    {

    }
}