using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Reduntant_Medicine_Donation_portal.Areas.Admin.Models;
using Reduntant_Medicine_Donation_portal.Data;

namespace Reduntant_Medicine_Donation_portal.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Administrator")]
    public class DashboardController : Controller
    {
        private readonly AppDbContext _context;
        public DashboardController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            
            var model = new DashBoardModel();
            return View(model);

        }

        public async Task<IActionResult> Donations()
        {
            return View(await _context.DonateMedicines.ToListAsync());
        }

        public async Task<IActionResult> Feedbacks()
        {
            return View(await _context.Feedbacks.ToListAsync());
        }

      
    }
}