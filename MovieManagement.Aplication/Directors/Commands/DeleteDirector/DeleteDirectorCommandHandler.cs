using MediatR;
using Microsoft.EntityFrameworkCore;
using MovieManagement.Aplication.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MovieManagement.Aplication.Directors.Commands.DeleteDirector
{
    public class DeleteDirectorCommandHandler : IRequestHandler<DeleteDirectorCommand>
    {
        private readonly IMovieDbContext _context;
        public DeleteDirectorCommandHandler(IMovieDbContext movieDbContext)
        {
            _context = movieDbContext;
        }

        public async  Task<Unit> Handle(DeleteDirectorCommand request, CancellationToken cancellationToken)
        {
            var director = await _context.Directors.Where(p => p.Id == request.DirectorId).FirstOrDefaultAsync(cancellationToken);

            _context.Directors.Remove(director);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
