using curso.api.Business.Entities;
using curso.api.Business.Repositories;
using curso.api.Configurations;
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
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IAuthenticationService _authenticationService;

        public UsuarioController(
            IUsuarioRepository usuarioRepository,
            IAuthenticationService authenticationService)
        {
            _usuarioRepository = usuarioRepository;
            _authenticationService = authenticationService;
        }


        [SwaggerResponse(statusCode: 200, description: "Sucesso ao autenticar", Type = typeof(LoginViewModelInput))]
        [SwaggerResponse(statusCode: 400, description: "Campos Obrigatórios",
            Type = typeof(ValidaCampoViewModelOutput))]
        [SwaggerResponse(statusCode: 500, description: "Erro Interno", Type = typeof(ErroGenericoViewModel))]
        [HttpPost]
        [Route("logar")]
        [ValidacaoModelStateCustomizado]
        public IActionResult Logar(LoginViewModelInput loginViewModelInput)
        {
            Usuario usuario = _usuarioRepository.ObterUsuario(loginViewModelInput.Login);

            if (usuario == null)
            {
                return BadRequest("Erro ao tentar acessar.");
            }

            var usuarioVieModelOutput = new UsuarioViewModelOutput()
            {
                Codigo = usuario.Codigo,
                Login = usuario.Login,
                Email = usuario.Email
            };


            var token = _authenticationService.GerarToken(usuarioVieModelOutput);


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
            // var optionsBuilder = new DbContextOptionsBuilder<CursoDbContext>();
            // optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=dotnetarquitetura;Integrated Security=True");
            // CursoDbContext contexto = new CursoDbContext(optionsBuilder.Options);

            // var migracoesPendentes = contexto.Database.GetPendingMigrations();
            //
            // if (migracoesPendentes.Count() > 0)
            // {
            //     contexto.Database.Migrate();
            // }

            var usuario = new Usuario();
            usuario.Email = registroViewModelInput.Email;
            usuario.Login = registroViewModelInput.Login;
            usuario.Senha = registroViewModelInput.Senha;

            _usuarioRepository.Adicionar(usuario);
            _usuarioRepository.Commit();


            return Created("", registroViewModelInput);
        }
    }
}