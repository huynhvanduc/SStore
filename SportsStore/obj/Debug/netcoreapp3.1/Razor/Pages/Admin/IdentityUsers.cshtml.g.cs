#pragma checksum "C:\Users\nguye\Desktop\SportsStore1-master\SportsStore\Pages\Admin\IdentityUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b74af99b2c05290e1684127b9167ea763478494"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SportsStore.Pages.Admin.Pages_Admin_IdentityUsers), @"mvc.1.0.razor-page", @"/Pages/Admin/IdentityUsers.cshtml")]
namespace SportsStore.Pages.Admin
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
#line 2 "C:\Users\nguye\Desktop\SportsStore1-master\SportsStore\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.RazorPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nguye\Desktop\SportsStore1-master\SportsStore\Pages\_ViewImports.cshtml"
using SportsStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\nguye\Desktop\SportsStore1-master\SportsStore\Pages\_ViewImports.cshtml"
using SportsStore.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nguye\Desktop\SportsStore1-master\SportsStore\Pages\Admin\IdentityUsers.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\nguye\Desktop\SportsStore1-master\SportsStore\Pages\Admin\IdentityUsers.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b74af99b2c05290e1684127b9167ea763478494", @"/Pages/Admin/IdentityUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db5cd140a63a3e465973e0b3b840d16d3cffe19c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_IdentityUsers : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h3 class=\"bg-primary text-white text-center p-2\">Admin User</h3>\r\n<table class=\"table table-sm table-striped table-bordered\">\r\n    <tbody>\r\n        <tr>\r\n            <th>User</th>\r\n            <td>");
#nullable restore
#line 11 "C:\Users\nguye\Desktop\SportsStore1-master\SportsStore\Pages\Admin\IdentityUsers.cshtml"
           Write(Model.AdminUser.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <th>Email</th>\r\n            <td>");
#nullable restore
#line 15 "C:\Users\nguye\Desktop\SportsStore1-master\SportsStore\Pages\Admin\IdentityUsers.cshtml"
           Write(Model.AdminUser.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n    </tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "C:\Users\nguye\Desktop\SportsStore1-master\SportsStore\Pages\Admin\IdentityUsers.cshtml"
           
    [Authorize]
    public class IdentityUsersModel : PageModel
    {
        private UserManager<IdentityUser> userManager;
        public IdentityUsersModel(UserManager<IdentityUser> mgr)
        {
            userManager = mgr;
        }
        public IdentityUser AdminUser { get; set; }
        public async Task OnGetAsync()
        {
            AdminUser = await userManager.FindByNameAsync("Admin");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IdentityUsersModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IdentityUsersModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IdentityUsersModel>)PageContext?.ViewData;
        public IdentityUsersModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
