using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eProdaja.Model.Requests;
using eProdaja.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.WebAPI.Controllers
{
    public class VrstaProizvodaController : BaseController<Model.Requests.VrsteProizvoda, object>
    {
        public VrstaProizvodaController(IService<VrsteProizvoda, object> service) : base(service)
        {
        }
    }
}