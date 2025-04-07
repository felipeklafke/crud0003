using CrudClients.Applications;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

public class BairroConverter : ValueConverter<Bairro, string>
{
    public BairroConverter() : base(
        dbValue => dbValue.ToString(),
        value => new Bairro(value))
    { 
        
    }
}