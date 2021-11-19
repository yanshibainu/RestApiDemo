using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestApiDemo.Service;
using RestApiDemo.Model;
using Microsoft.AspNetCore.Mvc;

namespace RestApiDemo.Controllers
{
    public abstract class AbstractController<TEntity, TViewModel> : Controller, IController<TEntity, TViewModel>
    {

        protected readonly IService<TEntity, TViewModel> _usersService;
        public AbstractController(IService<TEntity, TViewModel> usersService)
        {
            _usersService = usersService;
        }
        [HttpGet]
        public List<TEntity> Index()
        {
            return _usersService.All();
        }
        [HttpGet("{id}")]
        public TEntity Index(Guid id)
        {
            return _usersService.Find(id);
        }
        [HttpPost]
        public TEntity Create(TViewModel input)
        {
            return _usersService.Create(input);
        }
        [HttpPatch("{id}")]
        public TEntity Update(Guid id, TViewModel input)
        {
            return _usersService.Edit(id, input);
        }
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _usersService.Delete(id);
        }
    }
}
