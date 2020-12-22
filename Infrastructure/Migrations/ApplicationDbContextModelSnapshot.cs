﻿// <auto-generated />
using System;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Domain.Entities.Branch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Code")
                        .HasColumnType("text");

                    b.Property<int>("CountBed")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("integer");

                    b.Property<int>("HospitalId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("LastModifiedBy")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("HospitalId");

                    b.ToTable("Branch");
                });

            modelBuilder.Entity("Domain.Entities.District", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn()
                        .HasIdentityOptions(100L, null, null, null, null, null);

                    b.Property<string>("Code")
                        .HasColumnType("text");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("LastModifiedBy")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("RegionId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("RegionId");

                    b.ToTable("Districts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Code = "41711201000000",
                            Created = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Name = "Ленинский район",
                            RegionId = 1
                        },
                        new
                        {
                            Id = 56,
                            Code = "41711202000000",
                            Created = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Name = "Октябрьский район",
                            RegionId = 1
                        },
                        new
                        {
                            Id = 2,
                            Code = "41711203000000",
                            Created = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Name = "Первомайский район",
                            RegionId = 1
                        },
                        new
                        {
                            Id = 3,
                            Code = "41711204000000",
                            Created = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Name = "Свердловский район",
                            RegionId = 1
                        },
                        new
                        {
                            Id = 4,
                            Code = "41702205000000",
                            Created = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Name = "Ак-Суйский район",
                            RegionId = 3
                        },
                        new
                        {
                            Id = 5,
                            Code = "41702210000000",
                            Created = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Name = "Жети-Огузский район",
                            RegionId = 3
                        },
                        new
                        {
                            Id = 6,
                            Code = "41702215000000",
                            Created = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Name = "Иссык-Кульский район",
                            RegionId = 3
                        },
                        new
                        {
                            Id = 7,
                            Code = "41702220000000",
                            Created = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Name = "Тонский районрайон",
                            RegionId = 3
                        },
                        new
                        {
                            Id = 8,
                            Code = "41702225000000",
                            Created = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Name = "Тюпский район",
                            RegionId = 3
                        },
                        new
                        {
                            Id = 9,
                            Code = "41702420000010",
                            Created = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Name = "г. Балыкчы",
                            RegionId = 3
                        },
                        new
                        {
                            Id = 10,
                            Code = "41702410000010",
                            Created = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Name = "г. Каракол",
                            RegionId = 3
                        },
                        new
                        {
                            Id = 11,
                            Code = "41703204000000",
                            Created = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Name = "Ала-Букинский район",
                            RegionId = 4
                        },
                        new
                        {
                            Id = 12,
                            Code = "41703207000000",
                            Created = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Name = "Базар-Коргонский район",
                            RegionId = 4
                        },
                        new
                        {
                            Id = 13,
                            Code = "41703211000000",
                            Created = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Name = "Аксыйский район",
                            RegionId = 4
                        },
                        new
                        {
                            Id = 14,
                            Code = "41703215000000",
                            Created = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Name = "Ноокенский район",
                            RegionId = 4
                        },
                        new
                        {
                            Id = 15,
                            Code = "41703220000000",
                            Created = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Name = "Сузакский район",
                            RegionId = 4
                        },
                        new
                        {
                            Id = 16,
                            Code = "41703223000000",
                            Created = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Name = "Тогуз-Тороуский район",
                            RegionId = 4
                        },
                        new
                        {
                            Id = 17,
                            Code = "41703225000000",
                            Created = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Name = "Токтогульский район",
                            RegionId = 4
                        },
                        new
                        {
                            Id = 18,
                            Code = "41703230000000",
                            Created = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Name = "Чаткальский район",
                            RegionId = 4
                        },
                        new
                        {
                            Id = 19,
                            Code = "41703410000010",
                            Created = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Name = "г. Джалал-Абад",
                            RegionId = 4
                        },
                        new
                        {
                            Id = 20,
                            Code = "41703420000010",
                            Created = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Name = "г. Таш-Кумыр",
                            RegionId = 4
                        },
                        new
                        {
                            Id = 21,
                            Code = "41703430000010",
                            Created = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Name = "г. Майлуу-Суу",
                            RegionId = 4
                        },
                        new
                        {
                            Id = 22,
                            Code = "41703440000010",
                            Created = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Name = "г. Кара-Куль",
                            RegionId = 4
                        },
                        new
                        {
                            Id = 23,
                            Code = "41704210000000",
                            Created = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Name = "Ак-Талинский район",
                            RegionId = 4
                        },
                        new
                        {
                            Id = 24,
                            Code = "41704220000000",
                            Created = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Name = "Ат-Башынский район",
                            RegionId = 4
                        },
                        new
                        {
                            Id = 25,
                            Code = "41704230000000",
                            Created = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Name = "Жумгальский район",
                            RegionId = 5
                        },
                        new
                        {
                            Id = 26,
                            Code = "41704235000000",
                            Created = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Name = "Кочкорский район",
                            RegionId = 5
                        },
                        new
                        {
                            Id = 27,
                            Code = "41704245000000",
                            Created = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Name = "Нарынский район",
                            RegionId = 5
                        },
                        new
                        {
                            Id = 28,
                            Code = "41704400000010",
                            Created = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 4,
                            Name = "г. Нарын",
                            RegionId = 5
                        },
                        new
                        {
                            Id = 29,
                            Code = "41705214000000",
                            Created = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Name = "Баткенский район",
                            RegionId = 6
                        },
                        new
                        {
                            Id = 30,
                            Code = "41705236000000",
                            Created = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Name = "Лейлекский район",
                            RegionId = 6
                        },
                        new
                        {
                            Id = 31,
                            Code = "41705258000000",
                            Created = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Name = "Кадамжайский район",
                            RegionId = 6
                        },
                        new
                        {
                            Id = 32,
                            Code = "41705410000010",
                            Created = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Name = "г. Баткен",
                            RegionId = 6
                        },
                        new
                        {
                            Id = 33,
                            Code = "41705420000010",
                            Created = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Name = "г. Сулюкта",
                            RegionId = 6
                        },
                        new
                        {
                            Id = 34,
                            Code = "41705430000010",
                            Created = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Name = "г. Кызыл-Кия",
                            RegionId = 6
                        },
                        new
                        {
                            Id = 35,
                            Code = "41706207000000",
                            Created = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Name = "Алайский район",
                            RegionId = 7
                        },
                        new
                        {
                            Id = 36,
                            Code = "41706211000000",
                            Created = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Name = "Араванский район",
                            RegionId = 7
                        },
                        new
                        {
                            Id = 37,
                            Code = "41706226000000",
                            Created = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Name = "Кара-Сууский район",
                            RegionId = 7
                        },
                        new
                        {
                            Id = 38,
                            Code = "41706242000000",
                            Created = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Name = "Ноокатский район",
                            RegionId = 7
                        },
                        new
                        {
                            Id = 39,
                            Code = "41706246000000",
                            Created = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Name = "Кара-Кулжинский район",
                            RegionId = 7
                        },
                        new
                        {
                            Id = 40,
                            Code = "41706255000000",
                            Created = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Name = "Узгенский район",
                            RegionId = 7
                        },
                        new
                        {
                            Id = 41,
                            Code = "41706259000000",
                            Created = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Name = "Чон-Алайский  район",
                            RegionId = 7
                        },
                        new
                        {
                            Id = 42,
                            Code = "41707215000000",
                            Created = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Name = "Кара-Бууринский район",
                            RegionId = 7
                        },
                        new
                        {
                            Id = 43,
                            Code = "41707220000000",
                            Created = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Name = "Бакай-Атинский район",
                            RegionId = 8
                        },
                        new
                        {
                            Id = 44,
                            Code = "41707225000000",
                            Created = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Name = "Манасский район",
                            RegionId = 8
                        },
                        new
                        {
                            Id = 45,
                            Code = "41707232000000",
                            Created = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Name = "Таласский район",
                            RegionId = 8
                        },
                        new
                        {
                            Id = 46,
                            Code = "41707400000010",
                            Created = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 8,
                            Name = "г. Талас",
                            RegionId = 1
                        },
                        new
                        {
                            Id = 47,
                            Code = "41708203000000",
                            Created = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Name = "Аламудунский район",
                            RegionId = 9
                        },
                        new
                        {
                            Id = 48,
                            Code = "41708206000000",
                            Created = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Name = "Ысык-Атинский район",
                            RegionId = 9
                        },
                        new
                        {
                            Id = 49,
                            Code = "41708209000000",
                            Created = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Name = "Жайылский район",
                            RegionId = 9
                        },
                        new
                        {
                            Id = 50,
                            Code = "41708213000000",
                            Created = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Name = "Кеминский район",
                            RegionId = 9
                        },
                        new
                        {
                            Id = 51,
                            Code = "41708217000000",
                            Created = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Name = "Московский район",
                            RegionId = 9
                        },
                        new
                        {
                            Id = 52,
                            Code = "41708219000000",
                            Created = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Name = "Панфиловский район",
                            RegionId = 9
                        },
                        new
                        {
                            Id = 53,
                            Code = "41708222000000",
                            Created = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Name = "Сокулукский район",
                            RegionId = 9
                        },
                        new
                        {
                            Id = 54,
                            Code = "41708223000000",
                            Created = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Name = "Чуйский район",
                            RegionId = 9
                        },
                        new
                        {
                            Id = 55,
                            Code = "41708400000010",
                            Created = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Name = "г. Токмок",
                            RegionId = 9
                        });
                });

            modelBuilder.Entity("Domain.Entities.Hospital", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Adress")
                        .HasColumnType("text");

                    b.Property<string>("Boss")
                        .HasColumnType("text");

                    b.Property<string>("Code")
                        .HasColumnType("text");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("integer");

                    b.Property<int>("DistrictId")
                        .HasColumnType("integer");

                    b.Property<string>("FullName")
                        .HasColumnType("text");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("LastModifiedBy")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("DistrictId");

                    b.ToTable("Hospitals");
                });

            modelBuilder.Entity("Domain.Entities.Region", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn()
                        .HasIdentityOptions(100L, null, null, null, null, null);

                    b.Property<string>("Code")
                        .HasColumnType("text");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("LastModifiedBy")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Regions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Code = "41711000000000",
                            Created = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Name = "г. Бишкек"
                        },
                        new
                        {
                            Id = 2,
                            Code = "41721000000000",
                            Created = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Name = "г. Ош"
                        },
                        new
                        {
                            Id = 3,
                            Code = "41702000000000",
                            Created = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Name = "Иссык-Кульская область"
                        },
                        new
                        {
                            Id = 4,
                            Code = "41703000000000",
                            Created = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Name = "Джалал-Абадская область"
                        },
                        new
                        {
                            Id = 5,
                            Code = "41704000000000",
                            Created = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Name = "Нарынская область"
                        },
                        new
                        {
                            Id = 6,
                            Code = "41705000000000",
                            Created = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Name = "Баткенская область"
                        },
                        new
                        {
                            Id = 7,
                            Code = "41706000000000",
                            Created = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Name = "Ошская область"
                        },
                        new
                        {
                            Id = 8,
                            Code = "41707000000000",
                            Created = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Name = "Таласская область"
                        },
                        new
                        {
                            Id = 9,
                            Code = "41708000000000",
                            Created = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 1,
                            Name = "Чуйская область"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Branch", b =>
                {
                    b.HasOne("Domain.Entities.Hospital", "Hospital")
                        .WithMany("Branches")
                        .HasForeignKey("HospitalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hospital");
                });

            modelBuilder.Entity("Domain.Entities.District", b =>
                {
                    b.HasOne("Domain.Entities.Region", "Region")
                        .WithMany("Districts")
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Region");
                });

            modelBuilder.Entity("Domain.Entities.Hospital", b =>
                {
                    b.HasOne("Domain.Entities.District", "District")
                        .WithMany("Hospitals")
                        .HasForeignKey("DistrictId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("District");
                });

            modelBuilder.Entity("Domain.Entities.District", b =>
                {
                    b.Navigation("Hospitals");
                });

            modelBuilder.Entity("Domain.Entities.Hospital", b =>
                {
                    b.Navigation("Branches");
                });

            modelBuilder.Entity("Domain.Entities.Region", b =>
                {
                    b.Navigation("Districts");
                });
#pragma warning restore 612, 618
        }
    }
}
