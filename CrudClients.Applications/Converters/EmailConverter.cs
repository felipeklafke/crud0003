using CrudClients.Applications;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

public class EmailConverter : ValueConverter<Email, string>
{
    public EmailConverter() : base(
        dbValue => dbValue.ToString(),
        value => new Email(value))
    {

    }
}