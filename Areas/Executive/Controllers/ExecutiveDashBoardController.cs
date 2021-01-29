using MemberShip.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Reduntant_Medicine_Donation_portal.Areas.Executive.Models;
using Reduntant_Medicine_Donation_portal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Reduntant_Medicine_Donation_portal.Areas.Executive.Controllers
{
    [Area("Executive")]
    [Authorize(Roles = "Executive")]
    public class ExecutiveDashBoardController : Controller
    {
        private readonly AppDbContext _context;

        public ExecutiveDashBoardController(AppDbContext context)
        {
            _context = context;
        }
       
        public IActionResult Index()
        {
            var model = new ExecutiveDashBoardModel();
            return View(model);
        }

        public async Task<IActionResult> Donation()
        {
            var UserId = User.FindFirstValue(ClaimTypes.Name);
            return View(await _context.DonateMedicines.Where(d => d.ExecutiveMail == UserId).ToListAsync());
        }
    }
}
