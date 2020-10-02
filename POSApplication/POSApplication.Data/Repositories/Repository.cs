using POSApplication.Data.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace POSApplication.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, new()
    {
        private readonly PORTPOSContext _portPOSContext;

        public Repository(PORTPOSContext companydataContext)
        {
            _portPOSContext = companydataContext;
        }

        public IQueryable<TEntity> GetAll()
        {
            try
            {
                return _portPOSContext.Set<TEntity>();
            }
            catch (Exception)
            {
                throw new Exception("Couldn't retrieve entities");
            }
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException($"{nameof(AddAsync)} entity must not be null");
            }

            try
            {
                await _portPOSContext.AddAsync(entity);
                await _portPOSContext.SaveChangesAsync();

                return entity;
            }
            catch (Exception)
            {
                throw new Exception($"{nameof(entity)} could not be saved");
            }
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException($"{nameof(AddAsync)} entity must not be null");
            }

            try
            {
                _portPOSContext.Update(entity);
                await _portPOSContext.SaveChangesAsync();

                return entity;
            }
            catch (Exception)
            {
                throw new Exception($"{nameof(entity)} could not be updated");
            }
        }
    }
}
