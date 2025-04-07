using CrudClients.Applications;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

public class NumeroConverter : ValueConverter<Numero, string>
{
    public NumeroConverter() : base(
        dbValue => dbValue.ToString(),
        value => new Numero(value))
    { 
        
    }
}