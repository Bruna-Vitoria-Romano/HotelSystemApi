using HotelSystemApi.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystemApi.Domain.Entities
{
    public sealed class HotelGuest
    {
        public HotelGuest(int iD, string name, string phoneNumber, string email, string password, Rooms bookingId)
        {
            ID = iD;
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
            Password = password;
            BookingId = bookingId;
        }

        public HotelGuest(int id, string name)
        {
            ValidationDomainName(name);
            DomainExceptionValidation.When(id < 0, "Invalid Id.");
        }

        public int ID { get; private set; }
        public string Name { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public Rooms BookingId { get; private set; }

        private void ValidationDomainName(string name)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Invalid name. Name is required.");
            DomainExceptionValidation.When(name.Length < 3, "Name is to short.");
            
            Name = name;
            
        }

        private void ValidateDomain(string email, string password)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(email), "Invalid email. Email is required.");
            DomainExceptionValidation.When(string.IsNullOrEmpty(password), "Invalid password. Password is required.");

            Email = email;
            Password = password;
        }

        public void Update(string name, string email, string password) 
        {
            ValidateDomain(email, password);
            ValidationDomainName(name);
        }
    }
}
