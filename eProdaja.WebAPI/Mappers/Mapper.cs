using AutoMapper;
using eProdaja.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.WebAPI.Mappers
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Database.Korisnici, Model.Korisnici>();
            CreateMap<Database.Korisnici, KorisniciInsertRequest>().ReverseMap();
            CreateMap<Database.JediniceMjere, Model.Requests.JediniceMjere>().ReverseMap();
            CreateMap<Database.VrsteProizvoda, Model.Requests.VrsteProizvoda>().ReverseMap();
            CreateMap<Database.Proizvodi, Model.Requests.ProizvodUpsertRequest>().ReverseMap();
        }
    }
}
