using Application.Common.Interfaces;
using Application.Common.Models;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using P.Pager;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.MediatR.Regions.Queries
{
    public class GetRegionsQuery : IRequest<IPager<RegionDto>>
    {
        public int Page { get; set; } = 1;
    }

    public class GetRegionsQueryHandler : IRequestHandler<GetRegionsQuery, IPager<RegionDto>>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly ApplicationSettings _applicationSettings;

        public GetRegionsQueryHandler(IApplicationDbContext context, IMapper mapper, IOptions<ApplicationSettings> options)
        {
            _mapper = mapper;
            _context = context;
            _applicationSettings = options.Value;
        }

        public async Task<IPager<RegionDto>> Handle(GetRegionsQuery request, CancellationToken cancellationToken)
        {
            var query = _context.Regions.AsNoTracking();
            return await _mapper.ProjectTo<RegionDto>(query)
                .ToPagerListAsync(request.Page, _applicationSettings.PageSize, cancellationToken);
        }
    }
}