using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestApiDemo.Service;

namespace RestApiDemo.Controllers
{
    public abstract class AbstractController<TEntity, TViewModel> : Controller, IController<TEntity, TViewModel> where TEntity : class
    {
        protected readonly IRepository<TEntity, TViewModel> _Service;
        public AbstractController(IRepository<TEntity, TViewModel> Service)
        {
            _Service = Service;
        }
        [HttpGet]
        public List<TEntity> Index()
        {
            return _Service.All();
        }
        [HttpGet("{id}")]
        public TEntity Index(Guid id)
        {
            return _Service.Find(id);
        }
        [HttpPost]
        public TEntity Create(TEntity input)
        {
            return _Service.Create(input);
        }
        [HttpPatch("{id}")]
        public TEntity Update(Guid id, TViewModel input)
        {
            return _Service.Edit(id, input);
        }
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _Service.Delete(id);
        }
    }
}