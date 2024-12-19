using MediatR;
using RentACarFilterProject.DAL.Context;
using RentACarFilterProject.Features.Mediator.Commands.CarCommands;

namespace RentACarFilterProject.Features.Mediator.Handlers.CarHandlers
{
    public class DeleteCarCommandHandler : IRequestHandler<DeleteCarCommand>
    {
        private readonly RentACarFilterContext _context;

        public DeleteCarCommandHandler(RentACarFilterContext context)
        {
            _context = context;
        }

        public async Task Handle(DeleteCarCommand request, CancellationToken cancellationToken)
        {
            var value = await _context.Cars.FindAsync(request.Id);
            _context.Cars.Remove(value);
           await _context.SaveChangesAsync();
        }
    }
}
