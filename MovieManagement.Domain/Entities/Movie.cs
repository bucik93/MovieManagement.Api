using MovieManagement.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagement.Domain.Entities
{
    public class Movie : AuditableEntity
    {
        public string Name { get; set; }
        public int PremiereYear { get; set; }
        public int DirectorId { get; set; }
        public Director Director { get; set; }
        public List<Genre> Genres { get; private set; } = new List<Genre>();


    }
}
