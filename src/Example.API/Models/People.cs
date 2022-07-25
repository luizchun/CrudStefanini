using Example.API.Models.Exceptions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Example.API.Models
{
    public class People
    {
        public City City { get; set; }

        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(300)]
        public string Name { get; set; }

        [Required]
        [StringLength(11)]
        public string CPF { get; set; }

        [ForeignKey("City")]
        [Display(Name = "City name")]
        public int ID_City { get; set; }

        [Required]
        [StringLength(3)]
        public  int Age  { get; set; }
        
        public People()
        {
        }

        public People(string name, string cpf, int id_city, int age)
        {
            Name = name;
            CPF = cpf;
            ID_City = id_city;
            Age = age;
        }
        public static People Create(int cityId, string name, string cpf, int age)
        {
            if (name == null)
                throw new ArgumentException("Invalid " + nameof(name));

            if (cpf == null)
                throw new ArgumentException("Invalid " + nameof(cpf));

            if (age == 0)
                throw new ArgumentException("Invalid " + nameof(age));


            return new People(name, cpf, cityId, age);
        }

        public void Update(int cityId, string name, string cpf, int age)
        {
            ID_City = cityId;

            if (name != null)
                Name = name;

            if (cpf != null)
                CPF = cpf;

            if (age > 50)
                throw new InvalidAgeExceptions();

            if (age != 0)
                Age = age;
        }




    }
}
