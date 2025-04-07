using CrudClients.Applications;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

public class RazaoSocialConverter : ValueConverter<RazaoSocial, string>
{
    public RazaoSocialConverter() : base(
        dbValue => dbValue.ToString(),
        value => new RazaoSocial(value))
    { 
        
    }
}