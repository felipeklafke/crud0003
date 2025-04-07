using CrudClients.Applications;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

public class EnderecoConverter : ValueConverter<Endereco, string>
{
    public EnderecoConverter() : base(
        dbValue => dbValue.ToString(),
        value => new Endereco(value))
    { 
        
    }
}