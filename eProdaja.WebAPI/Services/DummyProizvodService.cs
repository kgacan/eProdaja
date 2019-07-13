using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eProdaja.Model;

namespace eProdaja.WebAPI.Services
{
    public class DummyProizvodService : IProizvodService
    {
        public IList<Proizvod> Get()
        {
            throw new NotImplementedException();
        }
    }
}
