using Booking_DataAccess.Context;
using Booking_DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_DataAccess.DataAccess.StructuresDataAccess
{
    public class StructuresDataAccess : IStructuresDataAccess
    {
        readonly BookingContext _context;

        public StructuresDataAccess(BookingContext context)
        {
            _context = context;
        }

        public async Task<List<Structures>> ListerAsync()
        {
            return await _context.Structures.ToListAsync();
        }
    }
}
