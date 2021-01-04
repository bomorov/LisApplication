using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Common.Interfaces;
using Application.Common.Models;
using AutoMapper;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using P.Pager;

namespace Application.MediatR.Districts.Queries
{
    public class GetDistrictsQuery:IRequest<List<DistrictDto>>
    {
       // public int Page { get; set; } = 1;
    }

    public class GetDistrictQueryHandler:IRequestHandler<GetDistrictsQuery, List<DistrictDto>>
    {
        private readonly IMapper _mapper;
        private readonly IApplicationDbContext _context;
        private readonly ApplicationSettings _applicationSettings;

        public GetDistrictQueryHandler(IApplicationDbContext context, IMapper mapper, IOptions<ApplicationSettings> options)
        {
            _mapper = mapper;
            _context = context;
            _applicationSettings = options.Value;
        }

        public async Task<List<DistrictDto>> Handle(GetDistrictsQuery request, CancellationToken cancellationToken)
        {
            var query =  _context.Districts.AsNoTracking();
            return await _mapper.ProjectTo<DistrictDto>(query)
                .ToListAsync();//(request.Page,_applicationSettings.PageSize,cancellationToken);

        }
    }
}
