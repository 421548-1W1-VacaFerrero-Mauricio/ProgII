using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiCripto2.Dto;
using WebApiCripto2.Service;

namespace WebApiCripto2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CriptoController : ControllerBase
    {
        private ICriptoService _service;

        public CriptoController(ICriptoService service)
        {
             _service = service;
        }

        [HttpGet("Categoria")]
        public async Task<IActionResult> GetByCategoria(string categoria, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _service.GetByCategoria(categoria, cancellationToken);
                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error del servidor, intente luego.");
            }
        }

        [HttpPut("{simbolo}")]
        public async Task<IActionResult> Update(string simbolo, [FromBody] CriptoPutDto dto, CancellationToken cancellationToken)
        {
            try
            {
                await _service.Update(simbolo, dto, cancellationToken);
                return Ok("Se actualizo correctame el valor y la fecha");

            }
            catch (ArgumentException ex)
            {
                return BadRequest(new { mensaje = ex.Message});
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id, CancellationToken cancellation)
        {
            try
            {
                var ok = await _service.Delete(id, cancellation);
                if(!ok)
                    return NotFound("La moneda no existe o ya esta inhabilitada.");

                return Ok("Se inhabilito correctamente.");

            }
            catch (Exception)
            {
                return StatusCode(500, "Error del servidor, intente luego.");
            }
        }
    }
}
