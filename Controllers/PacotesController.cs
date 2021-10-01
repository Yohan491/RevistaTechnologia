using System.Collections.Generic;
using System.Linq;
using tristezaTotal.Data;
using tristezaTotal.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace tristezaTotal.Controllers
{
    [ApiController]
    [Route("api/cadastro")]
    public class PacotesController : ControllerBase
    {
        private readonly PacoteContext _context;

        //Contructor
        public PacotesController(PacoteContext context) => _context = context;

        // create api/cadastro/create
        [HttpPost]
        [Route("api/create")]

        public Pacotes Create(Pacotes Item)
        {
            _context.Pacote.Add(Item);
            _context.SaveChanges();
            return Item;
        }

        [HttpGet]
        [Route("List")]

        public List<Pacotes> List() => _context.Pacote.ToList();

        [HttpGet]
        [Route(("getbyid/{Id}"))]

        public IActionResult GetbyId([FromRoute] int Id)
        {
            Pacotes pacotes = _context.Pacote.Find(Id);

            if (pacotes == null)
            {
                return NotFound();
            }
            return Ok(pacotes);
        }


    }

}