#pragma checksum "C:\Users\2091199\source\repos\ListingEmployees_UsingPartialView\ListingEmployees_UsingPartialView\Views\Shared\_EmployeeListPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d14e1cdbdef805cd8bba89b9c77a2562e3204372"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__EmployeeListPartial), @"mvc.1.0.view", @"/Views/Shared/_EmployeeListPartial.cshtml")]
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
#line 1 "C:\Users\2091199\source\repos\ListingEmployees_UsingPartialView\ListingEmployees_UsingPartialView\Views\_ViewImports.cshtml"
using ListingEmployees_UsingPartialView;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\2091199\source\repos\ListingEmployees_UsingPartialView\ListingEmployees_UsingPartialView\Views\_ViewImports.cshtml"
using ListingEmployees_UsingPartialView.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d14e1cdbdef805cd8bba89b9c77a2562e3204372", @"/Views/Shared/_EmployeeListPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f3a9da76cefe13d4d4855c16769e8e040cf55a4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__EmployeeListPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ListingEmployees_UsingPartialView.Models.Employee>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\2091199\source\repos\ListingEmployees_UsingPartialView\ListingEmployees_UsingPartialView\Views\Shared\_EmployeeListPartial.cshtml"
 foreach (var employee in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row col-md-4\">\r\n        <table>\r\n            <tr>\r\n                <td>Name:</td>\r\n                <td>");
#nullable restore
#line 9 "C:\Users\2091199\source\repos\ListingEmployees_UsingPartialView\ListingEmployees_UsingPartialView\Views\Shared\_EmployeeListPartial.cshtml"
               Write(employee.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Salary:</td>\r\n                <td>");
#nullable restore
#line 13 "C:\Users\2091199\source\repos\ListingEmployees_UsingPartialView\ListingEmployees_UsingPartialView\Views\Shared\_EmployeeListPartial.cshtml"
               Write(employee.Salary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n\r\n        </table>\r\n    </div>\r\n");
#nullable restore
#line 18 "C:\Users\2091199\source\repos\ListingEmployees_UsingPartialView\ListingEmployees_UsingPartialView\Views\Shared\_EmployeeListPartial.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ListingEmployees_UsingPartialView.Models.Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
