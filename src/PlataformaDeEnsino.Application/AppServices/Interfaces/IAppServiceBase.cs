using System.Collections.Generic;

namespace PlataformaDeEnsino.Application.AppServices.Interfaces
{
    public interface IAppServiceBase<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> ConsultarTodos();
        TEntity ConsultarPeloId(int id);
        void Inserir(TEntity obj);
        void Deletar(int id);
        void Atualizar(TEntity obj);
        void Dispose();
    }
}