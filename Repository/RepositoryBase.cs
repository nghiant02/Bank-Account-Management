using Microsoft.EntityFrameworkCore;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryBase <T> where T : class
    {
        private readonly BankAccountTypeContext _context;
        private readonly DbSet<T> _dbSet;

        public RepositoryBase()
        {
            _context = new BankAccountTypeContext();
            _dbSet = _context.Set<T>();
        }

        public List<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public void Create (T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public void Update (T entity)
        {
            _dbSet.Update(entity);
            _context.SaveChanges();
        }

        public void Delete (T entity)
        {
            _dbSet.Remove(entity);
            _context.SaveChanges();
        }
    }
}