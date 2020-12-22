using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace Infrastructure.Persistence.Seeds
{
    internal static class RegionSeed
    {
        private static DateTime _initialDate = new DateTime(1970, 1, 1);

        internal static ModelBuilder AddRegionSeedData(this ModelBuilder builder)
        {
            var regions = new Region[]
            {
                new Region {Id = 1, Name = "г. Бишкек", Code = "41711000000000", CreatedBy = 1, Created = _initialDate},
                new Region {Id = 2, Name = "г. Ош", Code = "41721000000000", CreatedBy = 1, Created = _initialDate},
                new Region {Id = 3, Name = "Иссык-Кульская область", Code = "41702000000000", CreatedBy = 1, Created = _initialDate},
                new Region {Id = 4, Name = "Джалал-Абадская область", Code = "41703000000000", CreatedBy = 1, Created = _initialDate},
                new Region {Id = 5, Name = "Нарынская область", Code = "41704000000000", CreatedBy = 1, Created = _initialDate},
                new Region {Id = 6, Name = "Баткенская область", Code = "41705000000000", CreatedBy = 1, Created = _initialDate},
                new Region {Id = 7, Name = "Ошская область", Code = "41706000000000", CreatedBy = 1, Created = _initialDate},
                new Region {Id = 8, Name = "Таласская область", Code = "41707000000000", CreatedBy = 1, Created = _initialDate},
                new Region {Id = 9, Name = "Чуйская область", Code = "41708000000000", CreatedBy = 1, Created = _initialDate},
            };
            builder.Entity<Region>().HasData(regions);

            return builder;
        }
    }
}