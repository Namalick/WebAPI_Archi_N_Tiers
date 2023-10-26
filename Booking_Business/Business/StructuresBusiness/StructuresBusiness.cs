using AutoMapper;
using Booking_Business.Dtos;
using Booking_DataAccess.DataAccess.StructuresDataAccess;
using Booking_DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Business.Business.StructuresBusiness
{
    public class StructuresBusiness :IStructuresBusiness
    {
        IMapper _mapper;
        IStructuresDataAccess _structuresDataAccess;

        public StructuresBusiness(IMapper mapper, IStructuresDataAccess structsDataAccess)
        {
            _structuresDataAccess = structsDataAccess;
            _mapper = mapper;
        }
        public async Task<List<StructuresDto>> ListerAsync()
        {

            List<Structures> entities = await _structuresDataAccess.ListerAsync();
            List<StructuresDto> dtos = _mapper.Map<List<StructuresDto>>(entities);

            return dtos;
        }

    }
}
