using DAL.Interfaces.Repositories;
using DAL.Domain.Base;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Linq;
using DAL.EntityFramework.Exceptions;
using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using DAL.Domain.Entities;

namespace DAL.EntityFramework.Repositories.Generic
{
    public abstract class GenericRepository<T>: IGenericRepository<T> where T:BaseEntity 
    {
        protected DbSet<T> DbSet { get; }
        protected DbContext context;
        protected GenericRepository(DbContext context)
        {
            DbSet = context.Set<T>();
            this.context = context;
        }

        public async Task<T> GetByIdAsync(int id)
        {
            // AsNoTracking() - ef not tracking changes in db and it works faster.
            var entity = await DbSetWithAllProperties()
                .AsNoTracking()
                .FirstOrDefaultAsync(p => p.Id == id);

            if(entity == null)
            {
                throw new DbRecordNotFoundException("Record with this id not found", id.ToString());
            }

            return entity; 
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            var entities = await DbSetWithAllProperties()
                .AsNoTracking()
                .ToListAsync();

            return entities;
        }

        protected abstract IQueryable<T> DbSetWithAllProperties();

        public async Task CreateAsync(T entity)
        {
            if(entity == null)
            {
                throw new ArgumentEntityNullInstanceException("Error in repository with entity while executing create", "entity");
            }

            await DbSet.AddAsync(entity);
            context.SaveChanges();
            
        }

        public void Remove(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentEntityNullInstanceException("Error in repository with entity while executing remove", "entity");
            }

            DbSet.Remove(entity);
        }

        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentEntityNullInstanceException("Error in repository with entity while executing update", "entity");
            }

            DbSet.Update(entity);
        }




    }
}

