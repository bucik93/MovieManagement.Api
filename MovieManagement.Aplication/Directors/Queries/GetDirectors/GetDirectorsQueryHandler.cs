using MediatR;
using Microsoft.EntityFrameworkCore;
using MovieManagement.Aplication.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MovieManagement.Aplication.Directors.Queries.GetDirectors
{
    public class GetDirectorsQueryHandler : IRequestHandler<GetDirectorsQuery, DirectorsVm>
    {
        private readonly IMovieDbContext _context;
        public GetDirectorsQueryHandler(IMovieDbContext context)
        {
            _context = context;
        }
        //TODO:
        public async Task<DirectorsVm> Handle(GetDirectorsQuery getDirectorsQuery, CancellationToken none)
        {
            //var directors = await _context.Directors.AsNoTracking().ToListAsync();

            //return new DirectorsVm() { Directors = directors };
            return null;
        }
    }
}
