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
    public class JediniceMjereController : BaseController<Model.Requests.JediniceMjere, object>
    {
        public JediniceMjereController(IService<Model.Requests.JediniceMjere, object> service) : base(service)
        {
        }
    }
}