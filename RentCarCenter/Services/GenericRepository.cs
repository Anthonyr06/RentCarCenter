using RentCarCenter.Models.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentCarCenter.Data;

namespace TRC.Bussiness.Repository
{
    public class GenericRepository<T> where T : class, IBaseEntity, new() 
    {
        private readonly RentCarDbContext _context;
        public DbSet<T> _set;
        public GenericRepository()
        {
            _context = new RentCarDbContext();
            _set = _context.Set<T>();
        }

        public virtual async Task<bool> Add(T entity)
        {
            await _set.AddAsync(entity);
            return true;
        }

        public virtual bool Update(T entity)
        {
            _set.Update(entity);
            return true;
        }
        
        public virtual async Task<IEnumerable<T>> GetAll(params string[] includes)
        {
            IQueryable<T> query = _set;

            foreach (var entity in includes)
               query = query.Include(entity);

            return await query.ToListAsync();
        }

        public virtual async Task<T> Get(int Id, params string[] includes)
        {
            IQueryable<T> query = _set;

            foreach (var entity in includes)
                query = query.Include(entity);

            return await query.FirstOrDefaultAsync(e => e.Id == Id);
        }

        public virtual async Task Delete(int id)
        {
            var entity = await _set.FirstOrDefaultAsync(e => e.Id == id);
            entity.Status = StatusEnum.Desactivado;
            Update(entity);
        }

        public virtual async Task<bool> SaveAsync()
        {
            try
            {
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception err)
            {
                throw new InvalidOperationException(err.Message);
            }
        }

    }
}
