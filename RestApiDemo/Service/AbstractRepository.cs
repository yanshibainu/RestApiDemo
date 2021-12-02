using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using RestApiDemo.Model;

namespace RestApiDemo.Service
{
    public abstract class AbstractRepository<TEntity, TViewModel>: IRepository<TEntity, TViewModel> where TEntity : class
    {
        protected readonly Microsoft.EntityFrameworkCore.DbContext _context;
        public AbstractRepository(Microsoft.EntityFrameworkCore.DbContext context)
        {
            _context = context;
        }
        public List<TEntity> All()
        {
            var List = _context.Set<TEntity>().ToList();
            return List;
        }
        public TEntity Find(Guid id)
        {
            var result = _context.Set<TEntity>().Find(id);
            return result;
        }
        public TEntity Create(TEntity input)
        {
            _context.Add(input);
            _context.SaveChanges();
            return input;
        }
        public void Delete(Guid id)
        {
            var deleteItem = _context.Set<TEntity>().Find(id);
            _context.Set<TEntity>().Remove(deleteItem);
            _context.SaveChanges();
        }
        public TEntity Edit(Guid id, TViewModel input)
        {
            var editItem = _context.Set<TEntity>().Find(id);
            _context.Entry(editItem).CurrentValues.SetValues(input);
            _context.SaveChanges();
            editItem = _context.Set<TEntity>().Find(id);
            return editItem;
        }
    }
}
