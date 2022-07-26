﻿using System.ComponentModel.DataAnnotations;

namespace Example.API.Services.Models.Request
{
    public class CreateCityRequest
    {
        [Required]
        [StringLength(200)]
        public string Name { get; set; }
        [Required]
        [StringLength(2)]
        public string UF { get; set; }
    }
}
