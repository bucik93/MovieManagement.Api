using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MovieManagement.Aplication.Common.Interfaces
{
    public interface IOmdbClient
    {
        Task<string> GetMovie(string searchFilter, CancellationToken cancellationToken);
    }
}
