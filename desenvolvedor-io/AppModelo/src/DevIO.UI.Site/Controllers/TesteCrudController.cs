using System;
using System.Linq;
using DevIO.UI.Site.Data;
using DevIO.UI.Site.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevIO.UI.Site.Controllers
{
    public class TesteCrudController : Controller
    {
        private readonly MeuDbContext _context;

        public TesteCrudController(MeuDbContext context)
        {
            _context = context;
        }

        // GET
        public IActionResult Index()
        {
            var aluno = new Aluno()
            {
                Nome = "Thone",
                DataDeNascimento = DateTime.Now,
                Email = "thone@email.com"
            };

            _context.Alunos.Add(aluno);
            _context.SaveChanges();

            var aluno2 = _context.Alunos.Find(aluno.Id);
            var aluno3 = _context.Alunos.FirstOrDefault(a => a.Email == "thone@email.com");
            var aluno4 = _context.Alunos.Where(a => a.Email == "Thone");

            aluno.Nome = "João";
            _context.Alunos.Update(aluno);
            _context.SaveChanges();

            _context.Alunos.Remove(aluno);
            _context.SaveChanges();
            
            return View();
        }
    }
}