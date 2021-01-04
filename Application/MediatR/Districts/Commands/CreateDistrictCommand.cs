using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Common.Interfaces;
using Application.Common.Models;
using Domain.Entities;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Application.MediatR.Districts.Commands
{
    public class CreateDistrictCommand:IRequest<(Result, int)>
    {
        public string Name { get; set; }
        public  string Code { get; set; }
    }

    public class CreateDistrictCommandHandler : IRequestHandler<CreateDistrictCommand, (Result, int)>
    {
        private readonly IApplicationDbContext _context;
        private readonly ILogger<CreateDistrictCommandHandler> _logger;
        public CreateDistrictCommandHandler(IApplicationDbContext context, ILogger<CreateDistrictCommandHandler> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<(Result, int)> Handle(CreateDistrictCommand request, CancellationToken cancellationToken)
        {
            try
            {
                District District = new District();
                District.Name = request.Name;
                District.Code = request.Code;
                District.RegionId = 2;
                _context.Districts.Add(District);
                await _context.SaveChangesAsync(cancellationToken);
                return (Result.Success(), District.Id);
            }
            catch (Exception e)
            {
                _logger.LogError($"Organization creation failed with error: {e.Message}");
                return (Result.Failure(ApplicationResources.CreationError), -1);
            }
        }
    }
}
