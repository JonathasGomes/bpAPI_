using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bpAPI.Controllers
{
    [Route("api/[controller]")]
    [AllowAnonymous]
    [ApiController]
    public class PessoaController : ControllerBase
    {

        private readonly DataContext _context;

        public PessoaController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Pessoa>>> Get()
        {
            return Ok(await _context.Pessoas.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Pessoa>> Get(int id)
        {
            var pessoa = await _context.Pessoas.FindAsync(id);
            if (pessoa == null)
                return BadRequest("Pessoa não encontrada");
            return Ok(pessoa);
        }

        [HttpPost]
        public async Task<ActionResult<List<Pessoa>>> AddPessoa(Pessoa pessoa)
        {
            _context.Pessoas.Add(pessoa);
            await _context.SaveChangesAsync();

            return Ok(await _context.Pessoas.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<Pessoa>>> UpdatePessoa(Pessoa request)
        {
            var BPDatabase = await _context.Pessoas.FindAsync(request.Id);
            if (BPDatabase == null)
                return BadRequest("Pessoa não encontrada");

            BPDatabase.Nome = request.Nome;
            BPDatabase.Telefone = request.Telefone;
            BPDatabase.CPF = request.CPF;
            BPDatabase.Email = request.Email;
            BPDatabase.Endereco = request.Endereco;
            BPDatabase.Numero = request.Numero;
            BPDatabase.Estado = request.Estado;
            BPDatabase.Cidade = request.Cidade;
            BPDatabase.Bairro = request.Bairro;

            await _context.SaveChangesAsync();

            return Ok(await _context.Pessoas.ToListAsync());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Pessoa>>> Delete(int id)
        {
            var BPDatabase = await _context.Pessoas.FindAsync(id);
            if (BPDatabase == null)
                return BadRequest("Pessoa não encontrada");

            _context.Pessoas.Remove(BPDatabase);
            await _context.SaveChangesAsync();

            return Ok(await _context.Pessoas.ToListAsync());
        }
    }
}
