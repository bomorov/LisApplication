using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.MediatR.Regions.Queries
{
    public  class GetRegionsQuery : IRequest<List<Region>> { }

    public class GetRegionsQueryHandler : IRequestHandler<GetRegionsQuery, List<Region>>
    {
        private readonly IApplicationDbContext _context;

        public GetRegionsQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<Region>> Handle(GetRegionsQuery request, CancellationToken cancellationToken)
        {
            return await _context.Regions.ToListAsync();
        }
    }
}


