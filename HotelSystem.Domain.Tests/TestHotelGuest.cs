using FluentAssertions;
using HotelSystem.Domain.Entities;

namespace HotelSystem.Domain.Tests
{
    public class TestHotelGuest
    {
        [Fact]
        public void CreateGuest_WithValidParameters_ResultObjectValidState()
        {
            Action action = () => new HotelGuest(1, "teste", "123456", "test@gmail.com", "456123", null);
            action.Should()
                .NotThrow<HotelSystem.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact]
        public void CreateGuest_NegativeIdValue_DomainExceptionValidationId()
        {
            Action action = () => new HotelGuest(-1, "teste");
            action.Should()
                .Throw<HotelSystem.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid Id.");
        }

        [Fact]
        public void CreateGuest_InvalidName_DomainExceptionValidationName()
        {
            Action action = () => new HotelGuest(1, "te");
            action.Should()
                .Throw<HotelSystem.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Name is to short.");
        }

        // Fazer mais testes
    }
}