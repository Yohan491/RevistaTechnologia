using System.Data;
using System.Collections.Generic;
using System.Linq;
using tristezaTotal.Data;
using tristezaTotal.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Extensions.Configuration;
namespace tristezaTotal.Controllers
{
    [ApiController]
    [Route("api/cadastro")]
    public class CadastroController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IConfiguration _configuration;
        //Constructor
        public CadastroController(DataContext context) => _context = context;

        // create api/cadastro/create
        [HttpPost]
        [Route("api/create")]

        public Cadastro Create(Cadastro Clientes)
        {
            _context.Cadastros.Add(Clientes);
            _context.SaveChanges();
            return Clientes;
        }

        //List GET
        [HttpGet]
        [Route("list")]
        public List<Cadastro> List() => _context.Cadastros.ToList();

        [HttpGet]
        [Route(("getbyid/{Id}"))]

        public IActionResult GetbyId([FromRoute] int Id)
        {
            Cadastro Cadastros = _context.Cadastros.Find(Id);

            if (Cadastros == null)
            {
                return NotFound();
            }

            return Ok(Cadastros);
        }
        public CadastroController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public JsonResult Get()
        {
            string query = @"
            Select id, username, senha, firstName, lastName from users;";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("UsuarioAppCon");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand meuComando = new SqlCommand(query, myCon))
                {
                    myReader = meuComando.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    myCon.Close();
                }
            }
            return new JsonResult(table);
        }

    }

}