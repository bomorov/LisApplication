using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Common.Interfaces;
using AutoMapper;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using P.Pager;

namespace Application.MediatR.Districts.Queries
{
    public class GetDistrictsQuery:IRequest<List<DistrictDto>>
    {
    }

    public class GetDistrictQueryHandler:IRequestHandler<GetDistrictsQuery, List<DistrictDto>>
    {
        private readonly IMapper _mapper;
        private readonly IApplicationDbContext _context;

        public GetDistrictQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<List<DistrictDto>> Handle(GetDistrictsQuery request, CancellationToken cancellationToken)
        {
            var query =  _context.Districts.AsNoTracking();
            return await _mapper.ProjectTo<DistrictDto>(query).ToListAsync();

        }
    }
}
