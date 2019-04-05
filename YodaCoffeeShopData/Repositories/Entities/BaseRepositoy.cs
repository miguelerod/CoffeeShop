using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using YodaCoffeeShopData.Repositories.Interfaces;

namespace YodaCoffeeShopData.Repositories.Entities
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected readonly YodaCoffeeShopContext Context;

        public BaseRepository(YodaCoffeeShopContext context)
        {
            Context = context;
        }

        public int Create(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
            Context.SaveChanges();

            PropertyInfo propertyInfo = entity.GetType().GetProperty("Id");
            var entityId = (int)propertyInfo.GetValue(entity);

            return entityId;
        }

        public void Delete(int id)
        {
            var entity = Context.Set<TEntity>().Find(id);

            PropertyInfo propertyInfo = entity.GetType().GetProperty("State");

            var entityStatus = (bool)propertyInfo.GetValue(entity);

            propertyInfo.SetValue(entity, false);

            Context.SaveChanges();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().AsNoTracking().Where(predicate).FirstOrDefault();
        }

        public IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().Where(predicate).ToList();
        }

        public void Update(TEntity entity)
        {
            var id = (int)entity.GetType().GetProperty("Id").GetValue(entity);

            var actualEntity = Context.Set<TEntity>().Find(id);

            Context.Entry(actualEntity).CurrentValues.SetValues(entity);
            Context.SaveChanges();
        }
    }
}
