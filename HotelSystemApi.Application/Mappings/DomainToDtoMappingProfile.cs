using AutoMapper;
using HotelSystemApi.Application.DTOs;
using HotelSystemApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystemApi.Application.Mappings
{
    public class DomainToDtoMappingProfile : Profile
    {
        public DomainToDtoMappingProfile() 
        {
            CreateMap<HotelGuest, HotelGuestDTO>().ReverseMap();
            CreateMap<HotelReception, HotelReceptionDTO>().ReverseMap();
            CreateMap<Rooms, RoomsDTO>().ReverseMap();
        }
    }
}
