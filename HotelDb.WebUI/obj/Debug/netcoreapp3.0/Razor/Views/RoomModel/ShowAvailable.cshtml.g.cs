#pragma checksum "d:\Repos\04 - HotelDB\HotelDb.WebUI\Views\RoomModel\ShowAvailable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb3b52954af93ce3a89f5d3ab18ce1ce27df1be3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RoomModel_ShowAvailable), @"mvc.1.0.view", @"/Views/RoomModel/ShowAvailable.cshtml")]
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
#line 1 "d:\Repos\04 - HotelDB\HotelDb.WebUI\Views\_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "d:\Repos\04 - HotelDB\HotelDb.WebUI\Views\_ViewImports.cshtml"
using WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb3b52954af93ce3a89f5d3ab18ce1ce27df1be3", @"/Views/RoomModel/ShowAvailable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc48f17eb9bac3476d8060730298bf398eb2fa5e", @"/Views/_ViewImports.cshtml")]
    public class Views_RoomModel_ShowAvailable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HotelDb.WebUI.Models.RoomModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "d:\Repos\04 - HotelDB\HotelDb.WebUI\Views\RoomModel\ShowAvailable.cshtml"
  
    ViewData["Title"] = "ShowAvailable";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 11 "d:\Repos\04 - HotelDB\HotelDb.WebUI\Views\RoomModel\ShowAvailable.cshtml"
           Write(Html.DisplayNameFor(model => model.RoomNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 14 "d:\Repos\04 - HotelDB\HotelDb.WebUI\Views\RoomModel\ShowAvailable.cshtml"
           Write(Html.DisplayNameFor(model => model.NumberBeds));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "d:\Repos\04 - HotelDB\HotelDb.WebUI\Views\RoomModel\ShowAvailable.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "d:\Repos\04 - HotelDB\HotelDb.WebUI\Views\RoomModel\ShowAvailable.cshtml"
           Write(Html.DisplayNameFor(model => model.Floor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "d:\Repos\04 - HotelDB\HotelDb.WebUI\Views\RoomModel\ShowAvailable.cshtml"
           Write(Html.DisplayNameFor(model => model.RoomInfo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n</table>\r\n<div style=\"height: 600px; overflow-y: scroll; overflow-x:hidden\">\r\n    <table class=\"table\">\r\n        <tbody>\r\n");
#nullable restore
#line 32 "d:\Repos\04 - HotelDB\HotelDb.WebUI\Views\RoomModel\ShowAvailable.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 36 "d:\Repos\04 - HotelDB\HotelDb.WebUI\Views\RoomModel\ShowAvailable.cshtml"
                   Write(Html.DisplayFor(modelItem => item.RoomNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 39 "d:\Repos\04 - HotelDB\HotelDb.WebUI\Views\RoomModel\ShowAvailable.cshtml"
                   Write(Html.DisplayFor(modelItem => item.NumberBeds));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 42 "d:\Repos\04 - HotelDB\HotelDb.WebUI\Views\RoomModel\ShowAvailable.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 45 "d:\Repos\04 - HotelDB\HotelDb.WebUI\Views\RoomModel\ShowAvailable.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Floor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 48 "d:\Repos\04 - HotelDB\HotelDb.WebUI\Views\RoomModel\ShowAvailable.cshtml"
                   Write(Html.DisplayFor(modelItem => item.RoomInfo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <span class=\"badge badge-light\">\r\n                            ");
#nullable restore
#line 52 "d:\Repos\04 - HotelDB\HotelDb.WebUI\Views\RoomModel\ShowAvailable.cshtml"
                       Write(Html.ActionLink("Edit", "Edit", new { id = item.RoomId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </span>\r\n                        <span class=\"badge badge-light\">\r\n                            ");
#nullable restore
#line 55 "d:\Repos\04 - HotelDB\HotelDb.WebUI\Views\RoomModel\ShowAvailable.cshtml"
                       Write(Html.ActionLink("Price", "ShowPrice", new { roomNumber = item.RoomNumber }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </span>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 59 "d:\Repos\04 - HotelDB\HotelDb.WebUI\Views\RoomModel\ShowAvailable.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HotelDb.WebUI.Models.RoomModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
