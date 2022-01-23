using MovieManagement.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagement.Domain.Entities
{
    public class Genre : AuditableEntity
    {
        public string Name { get; set; }
        public List<Movie> Movies { get; private set; } = new List<Movie>();
    }
}
