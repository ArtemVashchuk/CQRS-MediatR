using DemoLibrary.Models;
using MediatR;

namespace DemoLibrary.Commands
{
    public record CreatePersonCommand(PersonModel Person) : IRequest<PersonModel>;
}
