using System;
using PlataformaDeEnsino.Core.Entities;

namespace PlataformaDeEnsino.Core.Services.Interfaces
{
    public interface IProfessorService : IServiceBase<Professor>, IDisposable
    {
         Professor ConsultarPeloCpf(string cpfDoProfessor);
         Professor ConsultarPelaUnidade(int idDaUnidade);
    }
}