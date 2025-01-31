using HotelSystemApi.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystemApi.Domain.Entities
{
    public sealed class HotelReception
    {
        public HotelReception(int iD, string name, string email, string password, string position)
        {
            ID = iD;
            Name = name;
            Email = email;
            Password = password;
            Position = position;
        }

        public int ID { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public string Position { get; private set; }

        private void ValidationDomain(string name, string email, string password)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Invalid name. Name is required.");
            DomainExceptionValidation.When(name.Length < 3, "Name is to short.");
            DomainExceptionValidation.When(string.IsNullOrEmpty(email), "Invalid email. Email is required.");
            DomainExceptionValidation.When(string.IsNullOrEmpty(password), "Invalid password. Password is required.");

            Name = name;
            Email = email;
            Password = password;
        }

        public void Update(string name, string email, string password)
        {
            ValidationDomain(name, email, password);
        }

        public void ValidationRoom(int id)
        {
            DomainExceptionValidation.When(id < 0, "Invalid Id.");
            ID = id;
        }
        //verificar mudanças futuras para Guid Id
        //implementar Id já com o cargo definido
    }
}
