using DemoLibrary.Commands;
using DemoLibrary.DataAccess;
using DemoLibrary.Models;
using MediatR;

namespace DemoLibrary.Handlers
{
    public class CreatePersonHandler : IRequestHandler<CreatePersonCommand, PersonModel>
    {
        private readonly IDataAccess _data;

        public CreatePersonHandler(IDataAccess dataAccess)
        {
            _data = dataAccess;
        }

        public Task<PersonModel> Handle(CreatePersonCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.InsertPerson(request.Person.FirstName, request.Person.LastName));
        }
    }
}
