using System.Collections.Generic;
using System.Linq;
using curso.api.Business.Entities;
using curso.api.Business.Repositories;
using Microsoft.EntityFrameworkCore;

namespace curso.api.Infraestruture.Data.Repositories
{
    public class CursoRepository : ICursoRepository
    {
        private readonly CursoDbContext _contexto;

        public CursoRepository(CursoDbContext contexto)
        {
            this._contexto = contexto;
        }
        public void Adicionar(Curso curso)
        {
            _contexto.Add(curso);
        }

        public void Commit()
        {
            _contexto.SaveChanges();
        }

        public IList<Curso> OberPorUsuario(int codigoUsuario)
        {
            return _contexto.Set<Curso>().Include(i => i.Usuario).Where(c => c.CodigoUsuario == codigoUsuario).ToList();
        }
    }
}