using Booking_DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_DataAccess.DataAccess.StructuresDataAccess
{
    public interface IStructuresDataAccess
    {
        Task<List<Structures>> ListerAsync();
    }
}
