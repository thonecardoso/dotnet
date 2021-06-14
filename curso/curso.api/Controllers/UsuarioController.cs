using System.Linq;
using curso.api.Filters;
using curso.api.Models;
using curso.api.Models.Usuario;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace curso.api.Controllers
{
    [Route("api/v1/usuario")]
    [ApiController]
    public class UsuarioController : ControllerBase, UsuarioControllerDocs
    {
        [SwaggerResponse(statusCode: 200, description: "Sucesso ao autenticar", Type = typeof(LoginViewModelInput))]
        [SwaggerResponse(statusCode: 400, description: "Campos Obrigatórios",
            Type = typeof(ValidaCampoViewModelOutput))]
        [SwaggerResponse(statusCode: 500, description: "Erro Interno", Type = typeof(ErroGenericoViewModel))]
        [HttpPost]
        [Route("logar")]
        [ValidacaoModelStateCustomizado]
        public IActionResult Logar(LoginViewModelInput loginViewModelInput)
        {
            // if (!ModelState.IsValid)
            // {
            //     return BadRequest(new ValidaCampoViewModelOutput(ModelState.SelectMany(sm => sm.Value.Errors)
            //         .Select(s => s.ErrorMessage)));
            // }

            return Ok(loginViewModelInput);
        }

        [SwaggerResponse(statusCode: 201, description: "Sucesso ao criar registro",
            Type = typeof(RegistroViewModelInput))]
        [SwaggerResponse(statusCode: 400, description: "Campos Obrigatórios",
            Type = typeof(ValidaCampoViewModelOutput))]
        [SwaggerResponse(statusCode: 500, description: "Erro Interno", Type = typeof(ErroGenericoViewModel))]
        [HttpPost]
        [Route("registrar")]
        [ValidacaoModelStateCustomizado]
        public IActionResult Logar(RegistroViewModelInput registroViewModelInput)
        {
            
            // if (!ModelState.IsValid)
            // {
            //     return BadRequest(new ValidaCampoViewModelOutput(ModelState.SelectMany(sm => sm.Value.Errors)
            //         .Select(s => s.ErrorMessage)));
            // }
            
            return Created("", registroViewModelInput);
        }
    }
}