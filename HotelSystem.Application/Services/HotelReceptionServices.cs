using AutoMapper;
using HotelSystem.Application.DTOs;
using HotelSystem.Application.Interfaces;
using HotelSystem.Domain.Entities;
using HotelSystem.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.Application.Services
{
    public class HotelReceptionServices : IHotelReceptionServices
    {
        private IHotelReceptionRepository _repository;
        private readonly IMapper _mapper;
        public HotelReceptionServices(IHotelReceptionRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<HotelReceptionDTO>> GetHotelReception()
        {
            var receptionEntity = await _repository.GetHotelReceptionAsync();
            return _mapper.Map<IEnumerable<HotelReceptionDTO>>(receptionEntity);
        }

        public async Task<HotelReceptionDTO> GetById(int? id)
        {
            var receptionEntity = await _repository.GetHotelReceptionByIdAsync(id);
            return _mapper.Map<HotelReceptionDTO>(receptionEntity);
        }

        public async Task Add(HotelReceptionDTO receptionDto)
        {
            var receptionEntity = _mapper.Map<HotelReception>(receptionDto);
            await _repository.CreateAsync(receptionEntity);
        }

        public async Task Update(HotelReceptionDTO receptionDto)
        {
            var receptionEntity = _mapper.Map<HotelReception>(receptionDto);
            await _repository.UpdateAsync(receptionEntity);
        }

        public async Task Remove(int? id)
        {
            var receptionEntity = await _repository.GetHotelReceptionByIdAsync(id);
            await _repository.DeleteAsync(receptionEntity);
        }
    }
}
