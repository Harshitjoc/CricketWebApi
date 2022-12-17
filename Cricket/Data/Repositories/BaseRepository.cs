using Cricket.Data.Models;
using Cricket.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Cricket.Data.Repositories
{
    public class BaseRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        protected readonly CricketContext _context;
        public BaseRepository(CricketContext context)
        { 
            _context = context;
        }
        public virtual async Task<T> Add(T entity)
        {
            var data = (BaseEntity)entity;
            data.IsDeleted = false;
            data.IsEnabled = true;
            data.CreatedBy = 1;
            data.UpdatedBy= 1;
            data.CreatedDate= DateTime.Now;
            data.UpdatedDate = DateTime.Now;
            
            var result = await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public virtual async Task<bool> Delete(int id)
        {
            var entity = await _context.Set<T>().FindAsync(id);
            var data = (BaseEntity)entity;
            data.IsDeleted = true;
            data.IsEnabled = false;
            data.UpdatedBy = 1;
            data.UpdatedDate = DateTime.Now;
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
            return true;
        }

        public virtual async Task<List<T>> Get(Expression<Func<T, bool>> expression)
        {
           return await _context.Set<T>().Where(expression).ToListAsync();
        }

        public virtual async Task<IEnumerable<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public virtual async Task<T> GetById(int id)
        {
            var result = await _context.Set<T>().FindAsync(id);
            return result;
        }

        public virtual async Task<T> Update(T entity)
        {
            var data = (BaseEntity)entity;
            data.UpdatedBy = 1;
            data.UpdatedDate = DateTime.Now;
            _context.Entry(entity).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (ObjectDisposedException ex) 
            {
                Console.WriteLine(ex.Message);
            }
            return entity;
        }
    }
}
