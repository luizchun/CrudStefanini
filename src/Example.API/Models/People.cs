using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Example.API.Models
{
    public class People
    {
        [Required]
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




    }
}
