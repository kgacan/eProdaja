using AutoMapper;
using eProdaja.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.WebAPI.Services
{
    public class BaseService<TModel, TSearch, TDatabase> : IService<TModel, TSearch> where TDatabase: class
    {
        protected readonly eProdajaContext _context;
        protected readonly IMapper _mapper;

        public BaseService(eProdajaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public virtual List<TModel> Get(TSearch search)
        {
            var request = _context.Set<TDatabase>().ToList();

            return _mapper.Map<List<TModel>>(request);
        }

        public virtual TModel GetById(int id)
        {
            var request = _context.Set<TDatabase>().Find(id);

            return _mapper.Map<TModel>(request);
        }
    }
}
