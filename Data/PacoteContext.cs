using tristezaTotal.Controllers;
using Microsoft.EntityFrameworkCore;
using tristezaTotal.Models;
namespace tristezaTotal.Data
{
    public class PacoteContext : DbContext
    {
        //Construtor
        public PacoteContext(DbContextOptions<DataContext> options) : base(options) { }

        //Lista de propriedades das classes de modelo que vão virar tabelas no banco
        public DbSet<Pacotes> Pacote { get; set; }
    }


}