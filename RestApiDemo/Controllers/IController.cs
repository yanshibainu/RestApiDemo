using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiDemo.Controllers
{
    public interface IController<TEntity, TViewModel>
    {
        public List<TEntity> Index();
        public TEntity Index(Guid id);
        public TEntity Index(TViewModel input);
        public void Delete(Guid id);
        public TEntity Index(Guid id, TViewModel input);
    }
}
