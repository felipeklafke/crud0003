using CrudClients.Applications;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

public class CpfConverter : ValueConverter<Cpf, string>
{
    public CpfConverter() : base(
        dbValue => dbValue.ToString(),
        value => new Cpf(value))
    { 
        
    }
}