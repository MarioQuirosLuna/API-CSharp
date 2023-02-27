using Clinica_Salud_Con_API.Data;
using Clinica_Salud_Con_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Clinica_Salud_Con_API.Controllers
{
    [ApiController]
    [Route("api/medicos")]
    public class MedicoController : ControllerBase
    {
        [HttpGet]
        [Route("listarMedicos")]
        public async Task<ActionResult<List<Medico>>> ListarMedicos()
        {
            var function = new MedicoData();
            var listaMedicos = await function.MostrarMedicos();
            return Ok(listaMedicos);
        }
        [HttpPost]
        [Route("agregarMedico")]
        public async Task<ActionResult> AgregarMedico([FromBody] Medico medico)
        {
            var function = new MedicoData();
            await function.InsertarMedico(medico);
            return Ok();
        }
        [HttpPut]
        [Route("actualizarMedico")]
        public async Task<ActionResult> ActualizarMedico(int id, [FromBody] Medico medico)
        {
            var function = new MedicoData();
            medico.Id_Medico = id;
            await function.ActualizarMedico(medico);
            return NoContent();
        }
        [HttpDelete]
        [Route("eliminarMedico")]
        public async Task<ActionResult> EliminarMedico(int id)
        {
            var function = new MedicoData();
            await function.EliminarMedico(id);
            return NoContent();
        }
    }
}
