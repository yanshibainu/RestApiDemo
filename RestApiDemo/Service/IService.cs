using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestApiDemo.Model;
using Microsoft.EntityFrameworkCore;


namespace RestApiDemo.Service
{
    public interface IService<TEntity, TViewModel>
    {
        public List<TEntity> All();
        public TEntity Find(Guid id);
        public TEntity Create(TViewModel input);
        public void Delete(Guid id);
        public TEntity Edit(Guid id, TViewModel input);
    }
}
