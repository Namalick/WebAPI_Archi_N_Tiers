using Booking_Business.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Business.Business.StructuresBusiness
{
    public interface IStructuresBusiness
    {
        Task<List<StructuresDto>> ListerAsync();
    }
}
