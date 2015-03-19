using System.Linq;
using SurveyService.Model.Entities;

namespace SurveyService.Persistance.Common
{
    public interface IEntityRepository<TEntity> where TEntity : BaseEntity
    {

        TEntity GetById(long id);

        void Delete(TEntity entity);

        void Update(TEntity entity);

        void Insert(TEntity entity);

        IQueryable<TEntity> All();
    }
}
