using FluentAssertions;
using HotelSystemApi.Domain.Entities;

namespace HotelSystemApi.Domain.Tests
{
    public class TestHotelGuest
    {
        [Fact]
        public void CreateGuest_WithValidParameters_ResultObjectValidState()
        {
            Action action = () => new HotelGuest(1, "teste", "123456", "test@gmail.com", "456123", 1);
            action.Should()
                .NotThrow<HotelSystemApi.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact]
        public void CreateGuest_NegativeIdValue_DomainExceptionValidationId()
        {
            Action action = () => new HotelGuest(-1, "teste");
            action.Should()
                .Throw<HotelSystemApi.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid Id.");
        }

        [Fact]
        public void CreateGuest_InvalidName_DomainExceptionValidationName()
        {
            Action action = () => new HotelGuest(1, "te");
            action.Should()
                .Throw<HotelSystemApi.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Name is to short.");
        }

        // Fazer mais testes
    }
}