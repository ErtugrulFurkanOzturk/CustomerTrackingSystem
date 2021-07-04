using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Customerfollowingsystem.API.Dtos;
using Customerfollowingsystem.API.Models;

namespace Customerfollowingsystem.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            //Güncelleme tarihi gösterme müsteri bilgisi ile birlikte  
            CreateMap<Customer, CustomerForListDto>()
                .ForMember(update => update.Updatetime, opt =>
                {
                    opt.MapFrom(src => src.Values.FirstOrDefault(v => v.IsMain).Updatetime);
                });

            //Müşterinin ürününün detayları
            CreateMap<Customer, CustomerForDetailDto>();
        }
    }
}
