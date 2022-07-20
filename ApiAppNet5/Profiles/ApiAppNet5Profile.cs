using AutoMapper;
using ApiAppNet5.Data.Dtos;
using ApiAppNet5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiAppNet5.Profiles
{
    public class ApiAppNet5Profile : Profile
    {
        public ApiAppNet5Profile()
        {
            CreateMap<CreateApiAppNet5Dto, ApiAppNet5Profile>();
            CreateMap<ApiAppNet5Profile, ReadApiAppNet5Dto>();
            CreateMap<UpdateApiAppNet5Dto, ApiAppNet5Profile>();
        }
    }
}
