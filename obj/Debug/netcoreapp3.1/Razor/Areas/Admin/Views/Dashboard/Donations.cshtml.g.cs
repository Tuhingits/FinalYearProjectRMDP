#pragma checksum "D:\Reduntant Medicine Donation portal\ReduntantMedicineDonationPortal\Areas\Admin\Views\Dashboard\Donations.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "434703837d21556064e97e446c05cf41951158f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Dashboard_Donations), @"mvc.1.0.view", @"/Areas/Admin/Views/Dashboard/Donations.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Reduntant Medicine Donation portal\ReduntantMedicineDonationPortal\Areas\Admin\Views\_ViewImports.cshtml"
using Reduntant_Medicine_Donation_portal.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"434703837d21556064e97e446c05cf41951158f9", @"/Areas/Admin/Views/Dashboard/Donations.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acf53638b7635717a415e23fba30e091dc2eaf9b", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Dashboard_Donations : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Reduntant_Medicine_Donation_portal.Models.DonateMedicine>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Reduntant Medicine Donation portal\ReduntantMedicineDonationPortal\Areas\Admin\Views\Dashboard\Donations.cshtml"
  
    ViewData["Title"] = "Donations";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"content-wrapper\">\r\n    <h1>Donations</h1>\r\n\r\n    \r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 15 "D:\Reduntant Medicine Donation portal\ReduntantMedicineDonationPortal\Areas\Admin\Views\Dashboard\Donations.cshtml"
               Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 18 "D:\Reduntant Medicine Donation portal\ReduntantMedicineDonationPortal\Areas\Admin\Views\Dashboard\Donations.cshtml"
               Write(Html.DisplayNameFor(model => model.ExpireDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 21 "D:\Reduntant Medicine Donation portal\ReduntantMedicineDonationPortal\Areas\Admin\Views\Dashboard\Donations.cshtml"
               Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 24 "D:\Reduntant Medicine Donation portal\ReduntantMedicineDonationPortal\Areas\Admin\Views\Dashboard\Donations.cshtml"
               Write(Html.DisplayNameFor(model => model.DonarId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 27 "D:\Reduntant Medicine Donation portal\ReduntantMedicineDonationPortal\Areas\Admin\Views\Dashboard\Donations.cshtml"
               Write(Html.DisplayNameFor(model => model.OrgMail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 30 "D:\Reduntant Medicine Donation portal\ReduntantMedicineDonationPortal\Areas\Admin\Views\Dashboard\Donations.cshtml"
               Write(Html.DisplayNameFor(model => model.ExecutiveMail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 36 "D:\Reduntant Medicine Donation portal\ReduntantMedicineDonationPortal\Areas\Admin\Views\Dashboard\Donations.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 40 "D:\Reduntant Medicine Donation portal\ReduntantMedicineDonationPortal\Areas\Admin\Views\Dashboard\Donations.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 43 "D:\Reduntant Medicine Donation portal\ReduntantMedicineDonationPortal\Areas\Admin\Views\Dashboard\Donations.cshtml"
               Write(Html.DisplayFor(modelItem => item.ExpireDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 46 "D:\Reduntant Medicine Donation portal\ReduntantMedicineDonationPortal\Areas\Admin\Views\Dashboard\Donations.cshtml"
               Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 49 "D:\Reduntant Medicine Donation portal\ReduntantMedicineDonationPortal\Areas\Admin\Views\Dashboard\Donations.cshtml"
               Write(Html.DisplayFor(modelItem => item.DonarId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 52 "D:\Reduntant Medicine Donation portal\ReduntantMedicineDonationPortal\Areas\Admin\Views\Dashboard\Donations.cshtml"
               Write(Html.DisplayFor(modelItem => item.OrgMail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 55 "D:\Reduntant Medicine Donation portal\ReduntantMedicineDonationPortal\Areas\Admin\Views\Dashboard\Donations.cshtml"
               Write(Html.DisplayFor(modelItem => item.ExecutiveMail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n");
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 63 "D:\Reduntant Medicine Donation portal\ReduntantMedicineDonationPortal\Areas\Admin\Views\Dashboard\Donations.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Reduntant_Medicine_Donation_portal.Models.DonateMedicine>> Html { get; private set; }
    }
}
#pragma warning restore 1591
