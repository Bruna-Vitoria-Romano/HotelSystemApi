using AutoMapper;
using HotelSystemApi.Application.DTOs;
using HotelSystemApi.Application.Interfaces;
using HotelSystemApi.Domain.Entities;
using HotelSystemApi.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystemApi.Application.Services
{
    public class HotelGuestServices : IHotelGuestServices
    {
        private IHotelGuestRepository _repository;
        private readonly IMapper _mapper;
        public HotelGuestServices(IHotelGuestRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<HotelGuestDTO>> GetGuest()
        {
            var guestsEntity = await _repository.GetHotelGuestsAsync();
            return _mapper.Map<IEnumerable<HotelGuestDTO>>(guestsEntity);
        }

        public async Task<HotelGuestDTO> GetById(int? id)
        {
            var guestEntity = await _repository.GetHotelGuestByIdAsync(id);
            return _mapper.Map<HotelGuestDTO>(guestEntity);
        }

        public async Task Add(HotelGuestDTO guestDto)
        {
            var guestEntity = _mapper.Map<HotelGuest>(guestDto);
            await _repository.CreateAsync(guestEntity);
        }

        public async Task Update(HotelGuestDTO guestDto)
        {
            var guestEntity = _mapper.Map<HotelGuest>(guestDto);
            await _repository.UpdateAsync(guestEntity);
        }

        public async Task Remove(int? id)
        {
            var guestEntity = _repository.GetHotelGuestByIdAsync(id).Result;
            await _repository.DeleteAsync(guestEntity);
        }
    }
}
