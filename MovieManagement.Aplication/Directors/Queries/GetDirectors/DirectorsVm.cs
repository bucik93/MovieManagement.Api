using MovieManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagement.Aplication.Directors.Queries.GetDirectors
{
    public class DirectorsVm
    {
        public List<DirectorDto> Directors { get; set; }
    }
}
