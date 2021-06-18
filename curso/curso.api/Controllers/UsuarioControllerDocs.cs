﻿using curso.api.Models.Usuario;
using Microsoft.AspNetCore.Mvc;

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
        IActionResult Logar(RegistroViewModelInput registroViewModelInput);
    }

}