using System.Collections;
using System.Collections.Generic;
using curso.api.Business.Entities;

namespace curso.api.Business.Repositories
{
    public interface ICursoRepository
    {
        void Adicionar(Curso curso);
        void Commit();

        IList<Curso> OberPorUsuario(int codigoUsuario);
    }
}