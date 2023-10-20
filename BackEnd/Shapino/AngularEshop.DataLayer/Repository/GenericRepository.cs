using AngularEshop.DataLayer.Context;
using AngularEshop.DataLayer.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace AngularEshop.DataLayer.Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        #region constructor
        private AngularEshopDbContext Context;
        //از داخل کانتکست میخواهیم دی بی ست تی انتیتی را دریافت کنیم
        private DbSet<TEntity> Dbset;
        public GenericRepository(AngularEshopDbContext context)
        {
            this.Context = context;
            this.Dbset = this.Context.Set<TEntity>();
        }
        // کانتکست که شمای دیتابیس و تی انتیتی که از بیس انتیتی تبعیت میکن پس میگیم کانتکست مجموعه تی انتیتی را بده به دی بی ست
        #endregion
      
        public IQueryable<TEntity> GetEntitiesQuery()
        {
            return this.Dbset.AsQueryable();
        }

        public async Task<TEntity> GetEntityById(long entityId)
        {
            return await Dbset.SingleOrDefaultAsync(e => e.Id == entityId);
        }

        public async Task AddEntity(TEntity entity)
        {
            entity.CreateDate= DateTime.Now;
            entity.LastUpdateDate = entity.CreateDate;
            await Dbset.AddAsync(entity);
        }

        public void UpdateEntity(TEntity entity)
        {
            entity.LastUpdateDate = DateTime.Now;
            this.Dbset.Update(entity);
        }

        public void RemoveEntity(TEntity entity)
        {
           entity.IsDelete = true;

            UpdateEntity(entity);   
        }

        public async Task RemoveEntity(long entityId)
        {
            var entity = await GetEntityById(entityId);
            RemoveEntity(entity);   
        }    

        public async Task SaveChanges()
        {
            await Context.SaveChangesAsync();
        }


        public void Dispose()
        {
            Context?.Dispose();
        }
    }
}
