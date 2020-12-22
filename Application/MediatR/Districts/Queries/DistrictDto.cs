using System;
using System.Collections.Generic;
using System.Text;
using Application.Common.Mappings;
using AutoMapper;
using Domain.Entities;

namespace Application.MediatR.Districts.Queries
{
    public class DistrictDto:IMapFrom<District>
    {
        public int Id { get; set; }
        public  string Name { get; set; }
        public  string Code { get; set; }
        public  string Region { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<District, DistrictDto>()
                .ForMember(x => x.Region, opt => opt.MapFrom(x => x.Region.Name));
        }
    }

}
