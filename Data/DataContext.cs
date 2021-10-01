using tristezaTotal.Controllers;
using Microsoft.EntityFrameworkCore;
using tristezaTotal.Models;
namespace tristezaTotal.Data
{
    public class DataContext : DbContext
    {
        //Construtor
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        //Lista de propriedades das classes de modelo que vão virar tabelas no banco
        public DbSet<Cadastro> Cadastros { get; set; }
    }


}