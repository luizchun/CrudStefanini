using Example.API.Models;
using System.ComponentModel.DataAnnotations;

namespace Example.API.Services.Models.Dtos
{
    public class PeopleDto
    {
        public int Id { get; set; }
        public City City { get; set; }
        public string Name { get; set; }
        public string CPF { get; set; }
        public int Age { get; set; }

        public static explicit operator PeopleDto(People v)
        {
            return new PeopleDto()
            {
                Id = v.ID,
                City = v.City,
                Name = v.Name,
                CPF = v.CPF,
                Age = v.Age
            };
        }
    }
}
