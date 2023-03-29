using Microsoft.AspNetCore.Mvc;
using Tema_1.Entities;
using Tema_1.Services.StoveServices;

namespace Tema_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoveController : Controller
    {
        private readonly IStoveService _stoveService;
        public StoveController(IStoveService stoveService)
        {
            _stoveService = stoveService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Stove>>> GetAllStoves()
        {
            return await _stoveService.GetAllStoves();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Stove>> GetStoveById(int id)
        {
            var result = await _stoveService.GetStoveById(id);

            if (result is null)
            {
                return NotFound("Stove doesn't exist");
            }

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<Stove>>> AddStove(Stove stove)
        {
            var result = await _stoveService.AddStove(stove);
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult<List<Stove>>> UpdateStove(Stove stove)
        {
            var result = await _stoveService.UpdateStove(stove);

            if (result is null)
            {
                return NotFound("Stove doesn't exist");
            }

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Stove>> DeleteStove(int id)
        {
            var result = await _stoveService.DeleteStove(id);

            if (result == null)
            {
                return NotFound("Stove doesn't exist");
            }

            return Ok(result);
        }
    }
}
