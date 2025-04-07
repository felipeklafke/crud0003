using CrudClients.Applications;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

public class CidadeConverter : ValueConverter<Cidade, string>
{
    public CidadeConverter() : base(
        dbValue => dbValue.ToString(),
        value => new Cidade(value))
    {

    }
}