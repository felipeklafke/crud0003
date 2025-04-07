using CrudClients.Applications;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

public class TelefoneConverter : ValueConverter<Telefone, string>
{
    public TelefoneConverter() : base(
        dbValue => dbValue.ToString(),
        value => new Telefone(value))
    {

    }
}