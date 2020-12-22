using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Seeds
{
    internal static class PK_AutoIncrementSetting
    {
        internal static ModelBuilder SetPKAutoIncrementNumber(this ModelBuilder builder)
        {
            const int PK_INCREMENT_FROM = 100;

            builder.Entity<Region>().Property(b => b.Id).HasIdentityOptions(startValue: PK_INCREMENT_FROM);
            builder.Entity<District>().Property(b => b.Id).HasIdentityOptions(startValue: PK_INCREMENT_FROM);

           // builder.Entity<RoleAccessRight>().Property(b => b.Id).HasIdentityOptions(startValue: PK_INCREMENT_FROM);

            return builder;
        }
    }
}