using Example.API.Models;
using System.ComponentModel.DataAnnotations;

namespace Example.API.Services.Models.Dtos
{
    public class CityDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UF { get; set; }

        public static explicit operator CityDto(City v)
        {
            return new CityDto()
            {
                Id = v.Id,
                Name = v.Name,
                UF = v.UF
            };
        }
    }
}
