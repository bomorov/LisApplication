using System;
using System.Collections.Generic;
using System.Text;
using Application.Common.Mappings;
using AutoMapper;
using Domain.Entities;

namespace Application.MediatR.Regions.Queries
{
    public class RegionDto:IMapFrom<Region>
    {
        public int Id { get; set; }
        public  string Name { get; set; }
        public  string Code { get; set; }
        //public void Mapping (Profile profile)
        //{
        //    profile.CreateMap<Region, RegionDto>();


        //}
    }
}
