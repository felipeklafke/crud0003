using CrudClients.Applications;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

public class DataNascimentoConverter : ValueConverter<DataNascimento, string>
{
    public DataNascimentoConverter() : base(
        dbValue => dbValue.ToString(),
        value => new DataNascimento(new DateOnly()))
    {

    }
}