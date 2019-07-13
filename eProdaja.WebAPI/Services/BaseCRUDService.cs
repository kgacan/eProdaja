using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eProdaja.WebAPI.Database;

namespace eProdaja.WebAPI.Services
{
    public class BaseCRUDService<TModel, TSearch, TDatabase, IInsert, IUpdate> : BaseService<TModel, TSearch, TDatabase>, ICRUDService<TModel, TSearch, IInsert, IUpdate> where TDatabase: class
    {
        public BaseCRUDService(eProdajaContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public virtual TModel Insert(IInsert request)
        {
            var entity = _mapper.Map<TDatabase>(request);

            _context.Set<TDatabase>().Add(entity);
            _context.SaveChanges();

            return _mapper.Map<TModel>(entity);
        }

        public virtual TModel Update(int id, IUpdate request)
        {
            var entity = _context.Set<TDatabase>().Find(id);

            _context.Set<TDatabase>().Attach(entity);
            _context.Set<TDatabase>().Update(entity);

            _context.SaveChanges();

            return _mapper.Map<TModel>(entity);
        }
    }
}
