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
    public class RoomsServices : IRoomsServices
    {
        private IRoomRepository _repository;
        private readonly IMapper _mapper;
        public RoomsServices(IRoomRepository repository, IMapper mapper)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _mapper = mapper;
        }

        public async Task<IEnumerable<RoomsDTO>> GetRooms()
        {
            var roomsEntity = await _repository.GetRoomsAsync();
            return _mapper.Map<IEnumerable<RoomsDTO>>(roomsEntity);
        }

        public async Task<RoomsDTO> GetRoomsById(int? numberRoom)
        {
            var roomsEntity = await _repository.GetRoomsByIdAsync(numberRoom);
            return _mapper.Map<RoomsDTO>(roomsEntity);
        }

        public async Task<RoomsDTO> GetIdGuest(int? id)
        {
            var roomsEntity = await _repository.GetIdGuestByIdAsync(id);
            return _mapper.Map<RoomsDTO>(roomsEntity);
        }

        public async Task Add(RoomsDTO roomsDTO)
        {
            var roomsEntity = _mapper.Map<Rooms>(roomsDTO);
            await _repository.CreateAsync(roomsEntity);
        }

        public async Task update(RoomsDTO roomsDTO)
        {
            var roomsEntity = _mapper.Map<Rooms>(roomsDTO);
            await _repository.UpdateAsync(roomsEntity);
        }

        public async Task Remove(int? numberRoom)
        {
            var roomsEntity = _repository.GetIdGuestByIdAsync(numberRoom).Result;
            await _repository.DeleteAsync(roomsEntity);
        }
    }
}
