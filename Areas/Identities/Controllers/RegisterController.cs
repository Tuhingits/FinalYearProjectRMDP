using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemberShip.Context;
using MemberShip.Entities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using Reduntant_Medicine_Donation_portal.Areas.Identities.Models;
using Serilog;

namespace Reduntant_Medicine_Donation_portal.Areas.Identities.Controllers
{
    [Area("Identities")]
    //[Authorize(Roles = "SuperAdmin,Administrator")]
    public class RegisterController : Controller
    {
        
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;

        public RegisterController(ApplicationDbContext db, UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            ILogger<RegisterModel> logger)
        {
            
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
           
        }

        [BindProperty]
        public string ReturnUrl { get; set; }
        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public async Task<IActionResult> Registration()
        {
            var model = new RegisterModel();
            //ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Registration(RegisterModel Input, string returnUrl = null)
        {

            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser { 
                    UserName = Input.Email,
                    PhoneNumber = Input.PhoneNumber,
                    Email = Input.Email
                };
                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    var role = Input.USertype;
                    await _userManager.AddToRoleAsync(user, role);
                    _logger.LogInformation("User created a new account with password. Name: {0}",user.UserName);

                    var userId = await _userManager.FindByNameAsync(Input.Email);
                    var roleId = await _userManager.GetRolesAsync(userId);
                    if (roleId.Contains("Administrator") == true)
                    {
                        _logger.LogInformation("User logged in.");
                        return RedirectToAction("Index", "Dashboard", new { area = "Admin" });
                    }
                    else if (roleId.Contains("Executive") == true)
                    {
                        _logger.LogInformation("User logged in.");
                        return RedirectToAction("Index", "ExecutiveDashboard", new { area = "Executive" });
                    }
                    else if (roleId.Contains("Organization") == true)
                    {
                        _logger.LogInformation("User logged in.");
                        return RedirectToAction("Index", "OrganizerDashBoard", new { area = "Organizer" });
                    }
                    else if (roleId.Contains("Donor") == true)
                    {
                        return RedirectToAction("Index", "DonorDashBoard", new { area = "Donor" });
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                        return RedirectToActionPermanent("Index");
                    }
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return View(returnUrl);
        }
    }
}
