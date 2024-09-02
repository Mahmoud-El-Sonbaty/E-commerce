using MenStore.Application.Contracts;
using MenStore.Context;
using MenStore.Models;
using Microsoft.EntityFrameworkCore;

namespace MenStore.Infrastructure
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly StoreContext context; // should it be protected or private and each child create his own
        private readonly DbSet<T> dbSet;
        public GenericRepository(StoreContext _context)
        {
            this.context = _context;
            dbSet = context.Set<T>();

        }

        public T Create(T entity)
        {
            var x  = dbSet.Add(entity).Entity;
            context.SaveChanges();
            return x;
        }

        public T Update(T entity)
        {
            //var trackedEntities = context.ChangeTracker.Entries<context.Set<OrderMaster>()
            //    .Where(e => e.Id == entity is OrderDetail ? entity ).ToList();
            //foreach (var entry in trackedEntities)
            //{
            //    entry.State = EntityState.Detached;
            //}
            return dbSet.Update(entity).Entity;
        }

        public T Delete(T entity)
        {
            return dbSet.Remove(entity).Entity;
        }

        public IQueryable<T> GetAll()
        {
            return dbSet;
        }

        public T GetOne(int entityId)
        {
            return dbSet.Find(entityId);
        }

        public int SaveChanges()
        {
            return context.SaveChanges();
        }
    }
}
