using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PlataformaDeEnsino.Core.Entities;
using PlataformaDeEnsino.Core.Repositories;
using PlataformaDeEnsino.Core.Repositories.InstituicaoRepositories;

namespace PlataformaDeEnsino.Infrastructure.Repositories
{
    public class CoordenadorRepository : RepositoryBase<Coordenador>, ICoordenadorRepository
    {
       public async Task<Coordenador> ConsultarPeloCpfAsync(string cpfDaPessoa)
       {
           return await Context.Coordenadores.Where(c => c.CpfDaPessoa == cpfDaPessoa).FirstAsync();
       }
    }
}