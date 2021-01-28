using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Reduntant_Medicine_Donation_portal.Areas.Organizer.Models;
using Reduntant_Medicine_Donation_portal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Reduntant_Medicine_Donation_portal.Areas.Organizer.Controllers
{
    [Area("Organizer")]
    [Authorize(Roles = "Organizer")]
    public class OrganizerDashBoardController : Controller
    {
        private readonly AppDbContext _context;
        public OrganizerDashBoardController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var model = new OrganizerDashBoardModel();
            return View(model);
        }

        public async Task<IActionResult> Donations()
        {
            var UserId = User.FindFirstValue(ClaimTypes.Name);
            //return View(await _context.DonateMedicines.Where(d => d.OrgId == UserId).ToListAsync());
        }
    }
}
