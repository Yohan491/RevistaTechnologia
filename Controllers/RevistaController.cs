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
    public class RevistaController : ControllerBase
    {
        private readonly RevistaContext _context;

        //Contructor
        public RevistaController(RevistaContext context) => _context = context;

        // create api/cadastro/create
        [HttpPost]
        [Route("api/create")]

        public Revistas Create(Revistas revista)
        {
            _context.Revista.Add(revista);
            _context.SaveChanges();
            return revista;
        }

        [HttpGet]
        [Route("List")]

        public List<Revistas> List() => _context.Revista.ToList();

        [HttpGet]
        [Route(("getbyid/{Id}"))]

        public IActionResult GetbyId([FromRoute] int Id)
        {
            Revistas revista = _context.Revista.Find(Id);

            if (revista == null)
            {
                return NotFound();
            }
            return Ok(revista);
        }


    }

}