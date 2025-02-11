using FluentAssertions;
using HotelSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.Domain.Tests
{
    public class TestHotelReception
    {
        [Fact]
        public void CreateReception_WithValidParameters_ResultObjectValidState()
        {
            Action action = () => new HotelReception(1, "Teste", "teste@hotmail.com", "123", "Atendant");
            action.Should()
                .NotThrow<HotelSystem.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact]
        public void CreateReception_InvalidName_ResultObjectInvalidState()
        {
            Action action = () => new HotelReception(1, "te");
            action.Should()
                .Throw<HotelSystem.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Name is to short.");
        }
    }
}
