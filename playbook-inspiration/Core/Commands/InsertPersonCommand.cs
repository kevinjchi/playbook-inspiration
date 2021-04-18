using Core.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Commands
{
//    public record InsertPersonCommand(string FirstName, string LastName) : IRequest<PersonModel>;

    public class InsertPersonCommand : IRequest<PersonModel>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public InsertPersonCommand(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

        }
    }
}
