using Microsoft.EntityFrameworkCore;
using ZombieParty.Models.Data;

namespace ZombieParty.Services
{
    public class ServiceBaseAsync<T> : IServiceBaseAsync<T> where T : class

        /* La classe est aussi générique. T sera remplacé par le vrai type lors de l'utilisation. La classe implémente l'interface IServiceBaseAsync<T>. where T : class est une contrainte de type, il faut donc que T soit une classe. */
    {
        protected readonly ZombiePartyDbContext _dbContext;

        public ServiceBaseAsync(ZombiePartyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<T> CreateAsync(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public virtual async Task DeleteAsync(int id)
        {
            var entity = await this.GetByIdAsync(id);
            if (entity != null)
            {
                _dbContext.Set<T>().Remove(entity);
                await _dbContext.SaveChangesAsync();
            }

        }

        public async Task EditAsync(T entity)
        {
            if (_dbContext.Entry(entity).State == EntityState.Detached)
            {
                _dbContext.Update<T>(entity);
            }
            else
            {
                _dbContext.Entry(entity).State = EntityState.Modified;
            }

            await _dbContext.SaveChangesAsync();

        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task<T?> GetByIdAsync(int id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }
    }
}
