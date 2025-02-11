using AutoMapper;
using HotelSystem.Application.DTOs;
using HotelSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.Application.Mappings
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
