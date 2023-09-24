﻿using AngularEshop.DataLayer.Context;
using AngularEshop.DataLayer.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace AngularEshop.DataLayer.Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        #region constructor
        private AngularEshopDbContext context;
        //از داخل کانتکست میخواهیم دی بی ست تی انتیتی را دریافت کنیم
        private DbSet<TEntity> dbset;
        public GenericRepository(AngularEshopDbContext context)
        {
            this.context = context;
            this.dbset = this.context.Set<TEntity>();
        }
        // کانتکست که شمای دیتابیس و تی انتیتی که از بیس انتیتی تبعیت میکن پس میگیم کانتکست مجموعه تی انتیتی را بده به دی بی ست
        #endregion
      
        public IQueryable<TEntity> GetEntitiesQuery()
        {
            return this.dbset.AsQueryable();
        }

        public async Task<TEntity> GetEntityById(long entityId)
        {
            return await dbset.SingleOrDefaultAsync(e => e.Id == entityId);
        }

        public async Task AddEntity(TEntity entity)
        {
            entity.CreateDate= DateTime.Now;
            entity.LastUpdateDate = entity.CreateDate;
            await dbset.AddAsync(entity);
        }

        public void UpdateEntity(TEntity entity)
        {
            entity.LastUpdateDate = DateTime.Now;
            dbset.Update(entity);
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
            await context.SaveChangesAsync();
        }


        public void Dispose()
        {
            context?.Dispose();
        }
    }
}
