using AngularEshop.DataLayer.Entities.Common;

namespace AngularEshop.DataLayer.Repository
{//IDisposable برای اینکه گارنیش کانکشن در زمان اجرا فراخوانی شود و اگر کلاسی نیاز نبود اینستنت آن را از رم حذف کند
    public interface IGenericRepository<TEntity>:IDisposable where TEntity : BaseEntity
    {
        IQueryable<TEntity> GetEntitiesQuery();

        Task<TEntity> GetEntityById(long entityId);

        Task AddEntity(TEntity entity);

        void UpdateEntity(TEntity entity);

        void RemoveEntity(TEntity entity);

        Task RemoveEntity(long entityId);

        Task SaveChanges();
    }
}
