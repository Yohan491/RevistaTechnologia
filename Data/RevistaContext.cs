using tristezaTotal.Controllers;
using Microsoft.EntityFrameworkCore;
using tristezaTotal.Models;
namespace tristezaTotal.Data
{
    public class RevistaContext : DbContext
    {
        //Construtor
        public RevistaContext(DbContextOptions<DataContext> options) : base(options) { }

        //Lista de propriedades das classes de modelo que vão virar tabelas no banco
        public DbSet<Revistas> Revista { get; set; }
    }


}