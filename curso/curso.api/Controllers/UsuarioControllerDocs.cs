using curso.api.Models;
using curso.api.Models.Usuario;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace curso.api.Controllers
{
    public interface UsuarioControllerDocs
    {
        /// <summary>
        /// Este serviço permite autenticar um usuário cadastrado e ativo.
        /// </summary>
        /// <param name="loginViewModelInput">View model do ligin</param>
        /// <returns>Retorna status ok, dados do usuario e token em caso de sucesso</returns>
        IActionResult Logar(LoginViewModelInput loginViewModelInput);

        /// <summary>
        /// Este serviço permite registrar um usuário.
        /// </summary>
        /// <param name="registroViewModelInput">View model do registro</param>
        /// <returns>Retorna stratus created e dados do usuario em caso de sucesso</returns>
        [SwaggerResponse(statusCode: 201, description: "Sucesso ao criar registro",
            Type = typeof(RegistroViewModelInput))]
        [SwaggerResponse(statusCode: 400, description: "Campos Obrigatórios",
            Type = typeof(ValidaCampoViewModelOutput))]
        [SwaggerResponse(statusCode: 500, description: "Erro Interno", Type = typeof(ErroGenericoViewModel))]
        IActionResult Logar(RegistroViewModelInput registroViewModelInput);
    }

}