using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestApiDemo.Model;
using Microsoft.EntityFrameworkCore;
namespace RestApiDemo.Service
{
    public interface IRepository<TEntity, TViewModel> where TEntity : class
    {
        public List<TEntity> All();
        public TEntity Find(Guid id);
        public TEntity Create(TEntity input);
        public void Delete(Guid id);
        public TEntity Edit(Guid id, TViewModel input);
    }
}
