using CrudClients.Applications;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

public class NomeConverter : ValueConverter<Nome, string>
{
    public NomeConverter() : base(
        dbValue => dbValue.ToString(),
        value => new Nome(value))
    { 
        
    }
}