using MenStore.Application.Contracts;
using MenStore.Context;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

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
           
            return dbSet.Add(entity).Entity;
        }

        public T Update(T entity)
        {
            return dbSet.Update(entity).Entity;
        }

        public T Delete(T entity)
        {
            //context.Entry(entity).State = EntityState.Deleted;
            //Debug.WriteLine(context.Entry(entity).State);
           
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
