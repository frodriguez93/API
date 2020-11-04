using API_DTE.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API_DTE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BancoController : ControllerBase
    {
        private readonly IBancoRepository bancoRepository;

        public BancoController(IBancoRepository iBancoRepository)
        {
            this.bancoRepository = iBancoRepository;
        }

        //[Route("api/GetBanco/{IdBanco}")]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            Entity.Banco banco = await bancoRepository.GetAsync(id);
            
            if (banco != null)
            {
                return Ok(banco);
            }

            return NotFound();
        }
    }
}
