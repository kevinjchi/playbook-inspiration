using Core.DataAccess;
using Core.Models;
using Core.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Core.Handlers
{
    public class GetPersonListHandler : IRequestHandler<GetPersonListQuery, List<PersonModel>>
    {
        private readonly IDataAccess _data;
        public GetPersonListHandler(IDataAccess data)
        {
            _data = data;
        }
        public Task<List<PersonModel>> Handle(GetPersonListQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.GetPeople());
        }
    }
}
