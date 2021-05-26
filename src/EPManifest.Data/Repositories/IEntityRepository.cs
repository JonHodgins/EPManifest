using System.Threading.Tasks;
using EPManifest.Core;

namespace EPManifest.Data.Repositories
{
    public interface IEntityRepository<T>
    {
        Task<T> Create(T entity);

        Task Delete(T entity);

        void Dispose();

        Task Update(T entity);

        T GetById(int id);
    }
}
