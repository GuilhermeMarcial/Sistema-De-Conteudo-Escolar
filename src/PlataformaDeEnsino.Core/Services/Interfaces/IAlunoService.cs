using System;
using System.Collections.Generic;
using PlataformaDeEnsino.Core.Entities;

namespace PlataformaDeEnsino.Core.Services.Interfaces
{
    public interface IAlunoService : IServiceBase<Aluno>, IDisposable
    {
       Aluno ConsultarAlunoPeloCpf(string CpfDoAluno);
       IEnumerable<Aluno> SelecionarAlunosPeloCurso(int idDoCurso); 
    }
}