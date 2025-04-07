using CrudClients.Applications;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

public class CepConverter : ValueConverter<Cep, string>
{
    public CepConverter() : base(
        dbValue => dbValue.ToString(),
        value => new Cep(value))
    {

    }
}