using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;

namespace Infrastructure.Persistence.Seeds
{
    internal static class DistrictSeed
    {
        private static DateTime _initialDate = new DateTime(1970, 1, 1);
        internal static ModelBuilder AddDistrictSeedData(this ModelBuilder builder)
        {
            var districts = new District[]
            {
                new District { Id = 1, Name = "Ленинский район", Code = "41711201000000", RegionId = 1, CreatedBy = 1, Created = _initialDate },
                new District { Id = 56, Name = "Октябрьский район", Code = "41711202000000", RegionId = 1, CreatedBy = 1, Created = _initialDate },
                new District { Id = 2, Name = "Первомайский район", Code = "41711203000000",RegionId = 1,CreatedBy = 1, Created = _initialDate },
                new District { Id = 3, Name = "Свердловский район", Code = "41711204000000",RegionId = 1, CreatedBy = 1, Created = _initialDate },
                new District { Id = 4, Name = "Ак-Суйский район", Code = "41702205000000", RegionId = 3, CreatedBy = 1, Created = _initialDate },
                new District { Id = 5, Name = "Жети-Огузский район", Code = "41702210000000", RegionId = 3, CreatedBy = 1, Created = _initialDate },
                new District { Id = 6, Name = "Иссык-Кульский район", Code = "41702215000000", RegionId = 3, CreatedBy = 1,  Created = _initialDate },
                new District { Id = 7, Name = "Тонский районрайон", Code = "41702220000000", RegionId = 3, CreatedBy = 1, Created = _initialDate },
                new District { Id = 8, Name = "Тюпский район", Code = "41702225000000", RegionId = 3, CreatedBy = 1, Created = _initialDate },
                new District { Id = 9, Name = "г. Балыкчы", Code = "41702420000010", RegionId = 3, CreatedBy = 1,Created = _initialDate },
                new District { Id = 10, Name = "г. Каракол", Code = "41702410000010", RegionId = 3, CreatedBy = 1, Created = _initialDate },
                new District { Id = 11, Name = "Ала-Букинский район", Code = "41703204000000", RegionId = 4, CreatedBy = 1, Created = _initialDate },
                new District { Id = 12, Name = "Базар-Коргонский район", Code = "41703207000000", RegionId = 4, CreatedBy = 1, Created = _initialDate },
                new District { Id = 13, Name = "Аксыйский район", Code = "41703211000000", RegionId = 4, CreatedBy = 1, Created = _initialDate },
                new District { Id = 14, Name = "Ноокенский район", Code = "41703215000000",RegionId = 4, CreatedBy = 1, Created = _initialDate },
                new District { Id = 15, Name = "Сузакский район", Code = "41703220000000", RegionId = 4, CreatedBy = 1, Created = _initialDate },
                new District { Id = 16, Name = "Тогуз-Тороуский район", Code = "41703223000000", RegionId =4, CreatedBy = 1, Created = _initialDate },
                new District { Id = 17, Name = "Токтогульский район", Code = "41703225000000", RegionId = 4, CreatedBy = 1, Created = _initialDate },
                new District { Id = 18, Name = "Чаткальский район", Code = "41703230000000", RegionId = 4, CreatedBy = 1, Created = _initialDate },
                new District { Id = 19, Name = "г. Джалал-Абад", Code = "41703410000010", RegionId = 4, CreatedBy = 1, Created = _initialDate },
                new District { Id = 20, Name = "г. Таш-Кумыр", Code = "41703420000010", RegionId = 4, CreatedBy = 1, Created = _initialDate },
                new District { Id = 21, Name = "г. Майлуу-Суу", Code = "41703430000010", RegionId = 4, CreatedBy = 1, Created = _initialDate },
                new District { Id = 22, Name = "г. Кара-Куль", Code = "41703440000010", RegionId = 4, CreatedBy = 1, Created = _initialDate },
                new District { Id = 23, Name = "Ак-Талинский район", Code = "41704210000000", RegionId = 4, CreatedBy = 1, Created = _initialDate },
                new District { Id = 24, Name = "Ат-Башынский район", Code = "41704220000000", RegionId = 4, CreatedBy = 1, Created = _initialDate },
                new District { Id = 25, Name = "Жумгальский район", Code = "41704230000000", RegionId = 5, CreatedBy = 1, Created = _initialDate },
                new District { Id = 26, Name = "Кочкорский район", Code = "41704235000000", RegionId = 5, CreatedBy = 1, Created = _initialDate },
                new District { Id = 27, Name = "Нарынский район", Code = "41704245000000", RegionId = 5, CreatedBy = 1, Created = _initialDate },
                new District { Id = 28, Name = "г. Нарын", Code = "41704400000010",RegionId = 5, CreatedBy = 4, Created = _initialDate },
                new District { Id = 29, Name = "Баткенский район", Code = "41705214000000", RegionId = 6, CreatedBy = 1, Created = _initialDate },
                new District { Id = 30, Name = "Лейлекский район", Code = "41705236000000", RegionId = 6, CreatedBy = 1, Created = _initialDate },
                new District { Id = 31, Name = "Кадамжайский район", Code = "41705258000000", RegionId = 6, CreatedBy = 1, Created = _initialDate },
                new District { Id = 32, Name = "г. Баткен", Code = "41705410000010", RegionId = 6, CreatedBy = 1, Created = _initialDate },
                new District { Id = 33, Name = "г. Сулюкта", Code = "41705420000010",RegionId = 6, CreatedBy = 1, Created = _initialDate },
                new District { Id = 34, Name = "г. Кызыл-Кия", Code = "41705430000010", RegionId = 6, CreatedBy = 1, Created = _initialDate },
                new District { Id = 35, Name = "Алайский район", Code = "41706207000000",RegionId = 7, CreatedBy = 1, Created = _initialDate },
                new District { Id = 36, Name = "Араванский район", Code = "41706211000000", RegionId = 7, CreatedBy = 1, Created = _initialDate },
                new District { Id = 37, Name = "Кара-Сууский район", Code = "41706226000000",RegionId = 7, CreatedBy = 1, Created = _initialDate },
                new District { Id = 38, Name = "Ноокатский район", Code = "41706242000000", RegionId = 7, CreatedBy = 1, Created = _initialDate },
                new District { Id = 39, Name = "Кара-Кулжинский район", Code = "41706246000000", RegionId = 7, CreatedBy = 1, Created = _initialDate },
                new District { Id = 40, Name = "Узгенский район", Code = "41706255000000", RegionId = 7,CreatedBy = 1, Created = _initialDate },
                new District { Id = 41, Name = "Чон-Алайский  район", Code = "41706259000000", RegionId = 7, CreatedBy = 1, Created = _initialDate },
                new District { Id = 42, Name = "Кара-Бууринский район", Code = "41707215000000", RegionId = 7, CreatedBy = 1, Created = _initialDate },
                new District { Id = 43, Name = "Бакай-Атинский район", Code = "41707220000000", RegionId = 8, CreatedBy = 1, Created = _initialDate },
                new District { Id = 44, Name = "Манасский район", Code = "41707225000000", RegionId = 8, CreatedBy = 1, Created = _initialDate },
                new District { Id = 45, Name = "Таласский район", Code = "41707232000000", RegionId = 8, CreatedBy = 1, Created = _initialDate },
                new District { Id = 46, Name = "г. Талас", Code = "41707400000010", RegionId = 1, CreatedBy = 8, Created = _initialDate },
                new District { Id = 47, Name = "Аламудунский район", Code = "41708203000000", RegionId = 9, CreatedBy = 1, Created = _initialDate },
                new District { Id = 48, Name = "Ысык-Атинский район", Code = "41708206000000", RegionId = 9, CreatedBy = 1, Created = _initialDate },
                new District { Id = 49, Name = "Жайылский район", Code = "41708209000000", RegionId = 9, CreatedBy = 1, Created = _initialDate },
                new District { Id = 50, Name = "Кеминский район", Code = "41708213000000", RegionId = 9,CreatedBy = 1, Created = _initialDate },
                new District { Id = 51, Name = "Московский район", Code = "41708217000000", RegionId = 9, CreatedBy = 1, Created = _initialDate },
                new District { Id = 52, Name = "Панфиловский район", Code = "41708219000000",RegionId = 9, CreatedBy = 1, Created = _initialDate },
                new District { Id = 53, Name = "Сокулукский район", Code = "41708222000000", RegionId = 9, CreatedBy = 1, Created = _initialDate },
                new District { Id = 54, Name = "Чуйский район", Code = "41708223000000", RegionId = 9, CreatedBy = 1, Created = _initialDate },
                new District { Id = 55, Name = "г. Токмок", Code = "41708400000010",RegionId = 9, CreatedBy = 1, Created = _initialDate },

            };
            builder.Entity<District>().HasData(districts);

            return builder;
        }
    }
}
