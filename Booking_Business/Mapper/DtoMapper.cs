using AutoMapper;
using Booking_Business.Dtos;
using Booking_DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Business.Mapper
{
    public class DtoMapper :Profile
    {
        public DtoMapper() 
        {
            CreateMap<StructuresDto, Structures>().ReverseMap();
        }
    }
}
