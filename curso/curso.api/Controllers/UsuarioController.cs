using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using curso.api.Business.Entities;
using curso.api.Filters;
using curso.api.Infraestruture.Data;
using curso.api.Models;
using curso.api.Models.Usuario;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
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

            var usuarioVieModelOutput = new UsuarioViewModelOutput()
            {
                Codigo = 1,
                Login = "thonecardoso",
                Email = "thonecardoso@gmail.com"
            };

            var secret = Encoding.ASCII.GetBytes("MySecretMySecretMySecretMySecretMySecretMySecretMySecretMySecretMySecretMySecretMySecretMySecret");
            var symmetricSecurityKey = new SymmetricSecurityKey(secret);
            var securityTokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.NameIdentifier, usuarioVieModelOutput.Codigo.ToString()),
                    new Claim(ClaimTypes.Name, usuarioVieModelOutput.Login.ToString()),
                    new Claim(ClaimTypes.Email, usuarioVieModelOutput.Email.ToString()),
                }),
                Expires = DateTime.UtcNow.AddDays(1),
                SigningCredentials =
                    new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256Signature)
            };
            var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            var tokenGenerated = jwtSecurityTokenHandler.CreateToken(securityTokenDescriptor);
            var token = jwtSecurityTokenHandler.WriteToken(tokenGenerated);


            return Ok(
                new
                {
                    Token = token,
                    UsuarioViewModelOutput = usuarioVieModelOutput
                }
            );
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
            var optionsBuilder = new DbContextOptionsBuilder<CursoDbContext>();
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=dotnetarquitetura;Integrated Security=True");
            CursoDbContext contexto = new CursoDbContext(optionsBuilder.Options);

            var migracoesPendentes = contexto.Database.GetPendingMigrations();

            if (migracoesPendentes.Count() > 0)
            {
                contexto.Database.Migrate();
            }

            var usuario = new Usuario();
            usuario.Email = registroViewModelInput.Email;
            usuario.Login = registroViewModelInput.Login;
            usuario.Senha = registroViewModelInput.Senha;

            contexto.Usuarios.Add(usuario);
            contexto.SaveChanges();

            return Created("", registroViewModelInput);
        }
    }
}