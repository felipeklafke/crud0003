using Microsoft.EntityFrameworkCore;
using System.Data;
using FluentValidation.Validators;
using System.ComponentModel.DataAnnotations;
using FluentValidation;
using System.Linq.Expressions;


namespace CrudClients.Applications;


public class Clientes : DbContext, IClientes
{
    public DbSet<Cliente> ClientesRepository { get; set; }


    public Clientes() : base()
    {
        this.Database.EnsureCreated();
    }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase("ClientesDb");
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>().ToTable("Clientes");
        modelBuilder.Entity<Cliente>(p => p.HasKey(k => k.IdUnicoParaExemplo));
        modelBuilder.Entity<Cliente>(p => p.Property(pp => pp.IdUnicoParaExemplo));
        modelBuilder.Entity<Cliente>(p => p.Property(pp => pp.ClienteNome).HasConversion(new NomeConverter()));
        modelBuilder.Entity<Cliente>(p => p.Property(pp => pp.RazaoSocial).HasConversion(new RazaoSocialConverter()));
        modelBuilder.Entity<Cliente>(p => p.Property(pp => pp.ContatoEmail).HasConversion(new EmailConverter()));
        modelBuilder.Entity<Cliente>(p => p.Property(pp => pp.ContatoTelefone).HasConversion(new TelefoneConverter()));
        modelBuilder.Entity<Cliente>(p => p.Property(pp => pp.Estado).HasConversion(new EstadoConverter()));
        modelBuilder.Entity<Cliente>(p => p.Property(pp => pp.Cidade).HasConversion(new CidadeConverter()));
        modelBuilder.Entity<Cliente>(p => p.Property(pp => pp.Bairro).HasConversion(new BairroConverter()));
        modelBuilder.Entity<Cliente>(p => p.Property(pp => pp.Endereco).HasConversion(new EnderecoConverter()));
        modelBuilder.Entity<Cliente>(p => p.Property(pp => pp.Cep).HasConversion(new CepConverter()));
        modelBuilder.Entity<Cliente>(p => p.Property(pp => pp.Numero).HasConversion(new NumeroConverter()));
        modelBuilder.Entity<Cliente>(p => p.Property(pp => pp.Ie).HasConversion(new InscricaoEstadualConverter()));


        base.OnModelCreating(modelBuilder);
    }


    public IEnumerable<Cliente> Obter(Cliente cliente)
    {
        return this.ClientesRepository.AsNoTracking();
    }

    public void CadastrarAlteracoes(Cliente cliente)
    {

        // AbstractValidator<Cliente> validacoes = new ClienteValidator(this);
        // var res = validacoes.Validate(cliente);
        // var valid = res.IsValid;

        // if (valid && cliente.IdUnicoParaExemplo == 0)
        // {
        //     this.ClientesRepository.Add(cliente);
        //     this.SaveChanges();
        // }
        // else if (valid && cliente.IdUnicoParaExemplo != 0)
        // {
        //     this.ClientesRepository.Update(cliente);
        //     this.SaveChanges();
        // }

    }

    public void Remover(Cliente cliente)
    {
        if (cliente.IdUnicoParaExemplo != 0)
        {
            this.ClientesRepository.Remove(cliente);
            this.SaveChanges();
        }
    }

}