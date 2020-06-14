using Diplom.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiplomaWork.Helpers
{
    public class Repository : IRepository
    {
        public List<Plant> GetPlants()
        {
            return new List<Plant>()
            {
            new Plant(){Title="Lemon", FertiliDate = new DateTime(2020,6,12),WaterDate = new DateTime(2020,6,5) ,Picture = "https://www.starkbros.com/images/dynamic/2238-960x960.jpg"},
            new Plant(){Title="Orange",WaterDate = new DateTime(2020,6,10), FertiliDate = new DateTime(2020,5,9), Picture = "https://images-na.ssl-images-amazon.com/images/I/61w40sAWOdL.jpg"}
            };
        }
    }
}
