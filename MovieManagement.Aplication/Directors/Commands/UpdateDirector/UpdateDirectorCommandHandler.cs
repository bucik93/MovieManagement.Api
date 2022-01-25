using MediatR;
using Microsoft.EntityFrameworkCore;
using MovieManagement.Aplication.Common.Interfaces;
using MovieManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MovieManagement.Aplication.Directors.Commands.UpdateDirector
{
    public class UpdateDirectorCommandHandler : IRequestHandler<UpdateDirectorCommand>
    {
        private readonly IMovieDbContext _context;
        public UpdateDirectorCommandHandler(IMovieDbContext movieDbContext)
        {
            _context = movieDbContext;
        }
        public async Task<Unit> Handle(UpdateDirectorCommand request, CancellationToken cancellationToken)
        {
            var director = await _context.Directors.Where(p => p.Id == request.DirectorId).FirstOrDefaultAsync(cancellationToken);

            if(director == null)
            {
                return default;      
            }
            else
            {
                if (request.FirstName != null)
                    director.DirectorName.FirstName = request.FirstName;
                if (request.LastName != null)
                    director.DirectorName.LastName = request.LastName;
                if (request.DoB != null)
                    director.DirectorBiography.DoB = request.DoB;
                if (request.PlaceOfBirth != null)
                    director.DirectorBiography.PlaceOfBirth = request.PlaceOfBirth;

                _context.Directors.Update(director);

                await _context.SaveChangesAsync(cancellationToken);

                return Unit.Value;
            }
        }
    }
}
