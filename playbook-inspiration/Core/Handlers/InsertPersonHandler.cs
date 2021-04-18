using Core.Commands;
using Core.DataAccess;
using Core.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Core.Handlers
{
    public class InsertPersonHandler : IRequestHandler<InsertPersonCommand, PersonModel>
    {
        private readonly IDataAccess _data;

        public InsertPersonHandler(IDataAccess data)
        {
            _data = data;
        }
        public Task<PersonModel> Handle(InsertPersonCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.InsertPerson(request.FirstName, request.LastName);
        }
    }
}
