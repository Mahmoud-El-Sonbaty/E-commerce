using MenStore.Application.Contracts;
using MenStore.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenStore.Infrastructure
{
    public class Genericrepository<T> : IGenericRepository<T> where T : class
    {

        protected readonly StoreContext context;
        private readonly DbSet<T> dbSet;

        public Genericrepository(StoreContext context)
        {
            this.context = context;
            dbSet = context.Set<T>();
        }
        public T Create(T entity)
        {
            return dbSet.Add(entity).Entity;
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

        public T Update(T entity)
        {
            return dbSet.Update(entity).Entity;
        }
        public int savechanges()
        {
            return context.SaveChanges(); ;
        }
    }
}
