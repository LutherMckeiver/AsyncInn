using AsyncInn.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Controllers
{
    public class AmenitiesController : Controller
    {
        private readonly AsyncInnDbContext _context;

        public AmenitiesController(AsyncInnDbContext context)
        {
            _context = context;
        }
    }
}
