using System.Collections.Generic;
using PlataformaDeEnsino.Core.Entities;
using PlataformaDeEnsino.Core.Repositories;

namespace PlataformaDeEnsino.Core.Services.Interfaces
{
    public class ModuloService : ServiceBase<Modulo>, IModuloService
    {
        private readonly IModuloRepository _moduloRepository;

        public ModuloService(IModuloRepository moduloRepository) : base(moduloRepository)
        {
            _moduloRepository = moduloRepository;
        }
        public IEnumerable<Modulo> ConsultarModulosDoCurso(int idDoCurso)
        {
            return _moduloRepository.ConsultarModulosDoCurso(idDoCurso);
        }
        public IEnumerable<Modulo> ConsultarModulosDoCurso(int idDoCurso, int nivelDoAluno)
        {
            return _moduloRepository.ConsultarModulosDoCurso(idDoCurso, nivelDoAluno);
        }
    }
}