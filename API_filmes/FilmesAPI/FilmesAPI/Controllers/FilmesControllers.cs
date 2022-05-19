using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesAPI.Controllers
{       
    [ApiController]
    [Route("[controller]")]
    public class FilmesControllers : ControllerBase
    {
        private static List<Filme> filmes = new List<Filme>();
        private static int id = 1;


        [HttpPost]
        //função de cadastrar os dados no sistema
        public IActionResult AdicionaFilme([FromBody]Filme filme)
        {
            filme.Id = id++;
            filmes.Add(filme);
            return CreatedAtAction(nameof(RecuperaFilmesPorId), new { id = filme.Id }, filme);
        }

        [HttpGet]   
        public IActionResult RecuperaFilmes()
        {
            return Ok(filmes);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaFilmesPorId(int id)
        {
           Filme filme = filmes.FirstOrDefault(filme => filme.Id == id);
            if(filme != null)
            {
                return Ok(filme);
            }
            return NotFound();
        }
    }
}
