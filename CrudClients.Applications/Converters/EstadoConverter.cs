using CrudClients.Applications;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

public class EstadoConverter : ValueConverter<Estado, string>
{
    public EstadoConverter() : base(
        dbValue => dbValue.ToString(),
        value => new Estado(value))
    { 
        
    }
}