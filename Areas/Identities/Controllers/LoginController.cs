﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemberShip.Entities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using Reduntant_Medicine_Donation_portal.Areas.Identities.Models;

namespace Reduntant_Medicine_Donation_portal.Areas.Identities.Controllers
{
    [AllowAnonymous]
    [Area("Identities")]
    public class LoginController : Controller
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger<LoginModel> _logger;

        public LoginController(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            ILogger<LoginModel> logger)
        {

            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;

        }
        [BindProperty]

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }
        public string ErrorMessage { get; set; }

        public async Task<IActionResult> Index()
        {
            var model = new LoginModel();

            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Index(LoginModel Input, string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");

            if (ModelState.IsValid)
            {
                // This doesn't count login failures towards account lockout
                // To enable password failures to trigger account lockout, set lockoutOnFailure: true
                var result = await _signInManager.PasswordSignInAsync(Input.Email, Input.Password, Input.RememberMe, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    var user = await _userManager.FindByNameAsync(Input.Email);
                    var role = await _userManager.GetRolesAsync(user);
                    if (role.Contains("Administrator") == true)
                    {
                        _logger.LogInformation("User logged in.");
                        return RedirectToAction("Index", "Dashboard", new { area = "Admin" });
                    }
                    else if (role.Contains("Executive") == true)
                    {
                        _logger.LogInformation("User logged in.");
                        return RedirectToAction("Index", "ExecutiveDashboard", new { area = "Executive" });
                    }
                    else if (role.Contains("Organization") == true)
                    {
                        _logger.LogInformation("User logged in.");
                        return RedirectToAction("Index", "OrganizerDashBoard", new { area = "Organizer" });
                    }
                    else if (role.Contains("Donor") == true)
                    {
                        return RedirectToAction("Index", "DonorDashBoard", new { area = "Donor" });
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                        return RedirectToActionPermanent("Index");
                    }
                }

                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return View(Input);
                }

            }

            // If we got this far, something failed, redisplay form
            return View(returnUrl);
        }
    }
}
