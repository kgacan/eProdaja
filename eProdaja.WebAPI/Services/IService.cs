﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.WebAPI.Services
{
    public interface IService<TModel, TSearch>
    {
        List<TModel> Get(TSearch search);
        TModel GetById(int id);
    }
}
