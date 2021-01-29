using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Reduntant_Medicine_Donation_portal.Areas.Organizer.Models;
using Reduntant_Medicine_Donation_portal.Data;
using Reduntant_Medicine_Donation_portal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Reduntant_Medicine_Donation_portal.Areas.Organizer.Controllers
{
    [Area("Organizer")]
    [Authorize(Roles = "Organization")]
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
        public async Task<IActionResult> Feedbackss()
        {
            return View(await _context.Feedbacks.ToListAsync());
        }


        public async Task<IActionResult> Donations()
        {
            var UserMail = User.FindFirstValue(ClaimTypes.Name);
            return View(await _context.DonateMedicines.Where(d => d.OrgMail == UserMail).ToListAsync());
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var donateMedicine = await _context.DonateMedicines.FindAsync(id);
            if (donateMedicine == null)
            {
                return NotFound();
            }
            return View(donateMedicine);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,ExpireDate,Quantity,DonarId,OrgMail,ExecutiveMail")] DonateMedicine donateMedicine)
        {
            if (id != donateMedicine.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(donateMedicine);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DonateMedicineExists(donateMedicine.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(donateMedicine);
        }

        private bool DonateMedicineExists(int id)
        {
            return _context.DonateMedicines.Any(e => e.Id == id);
        }
    }
}
