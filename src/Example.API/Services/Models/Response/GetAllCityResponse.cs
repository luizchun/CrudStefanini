﻿using Example.API._Common;
using Example.API.Services.Models.Dtos;

namespace Example.API.Services.Models.Response
{
    public class GetAllCityResponse : BaseResponse
    {
        public List<CityDto> Cities { get; set; }
    }
}
