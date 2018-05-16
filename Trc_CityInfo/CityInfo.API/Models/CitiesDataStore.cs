using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityInfo.API.Models
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();

        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "Sofia",
                    Description = "The capital",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "National Museum of History",
                            Description = "The Biggest Historical Museum"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "St Sofia",
                            Description = "Church, symbol of the Sofia"
                        }
                    }
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Plovdiv",
                    Description = "The oldest town center",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 3,
                            Name = "Antient Stadium",
                            Description = "Roman Theater and stadium"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 4,
                            Name = "Old Town",
                            Description = "Old town in the City center"
                        }
                    }
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Varna",
                    Description = "The sea capital of Bulgaria",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 5,
                            Name = "Vladislav Varnenchik Museum",
                            Description = "Museum of the hero Varnenchik"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 6,
                            Name = "Sea Museum",
                            Description = "Sea flora and fauna museum"
                        }
                    }
                }
            };
        }
    }
}
