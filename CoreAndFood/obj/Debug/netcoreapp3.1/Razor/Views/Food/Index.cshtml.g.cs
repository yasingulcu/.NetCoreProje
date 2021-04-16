#pragma checksum "C:\Users\ysg02\Desktop\CoreCalisma\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f743954e5ca52ce1e61e53e5c627758f06de25f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Food_Index), @"mvc.1.0.view", @"/Views/Food/Index.cshtml")]
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
#line 1 "C:\Users\ysg02\Desktop\CoreCalisma\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ysg02\Desktop\CoreCalisma\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f743954e5ca52ce1e61e53e5c627758f06de25f", @"/Views/Food/Index.cshtml")]
    public class Views_Food_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<CoreAndFood.Data.Models.Food>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\ysg02\Desktop\CoreCalisma\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Food List</h1>
<br />
<table class=""table table-bordered"">
    <tr>
        <th>ID</th>
        <th>Food Name</th>
        <th>Price</th>
        <th>Stock</th>
        <th>Category Name</th>
        <th>Delete</th>
        <th>Update</th>
        <th>Details</th>
    </tr>
");
#nullable restore
#line 22 "C:\Users\ysg02\Desktop\CoreCalisma\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
     foreach (var x in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th>");
#nullable restore
#line 25 "C:\Users\ysg02\Desktop\CoreCalisma\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
           Write(x.FoodID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\ysg02\Desktop\CoreCalisma\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
           Write(x.FoodName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\ysg02\Desktop\CoreCalisma\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
           Write(x.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\ysg02\Desktop\CoreCalisma\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
           Write(x.Stock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\ysg02\Desktop\CoreCalisma\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
           Write(x.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 726, "\"", 759, 2);
            WriteAttributeValue("", 733, "/Food/DeleteFood/", 733, 17, true);
#nullable restore
#line 30 "C:\Users\ysg02\Desktop\CoreCalisma\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
WriteAttributeValue("", 750, x.FoodID, 750, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 814, "\"", 844, 2);
            WriteAttributeValue("", 821, "/Food/FoodGet/", 821, 14, true);
#nullable restore
#line 31 "C:\Users\ysg02\Desktop\CoreCalisma\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
WriteAttributeValue("", 835, x.FoodID, 835, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Update</a>\r\n            <td><a href=\"#\" class=\"btn btn-info\">Details</a>\r\n        </tr>\r\n");
#nullable restore
#line 34 "C:\Users\ysg02\Desktop\CoreCalisma\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
#nullable restore
#line 36 "C:\Users\ysg02\Desktop\CoreCalisma\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
Write(Html.PagedListPager((IPagedList)Model, page=>Url.Action("Index",new { page})));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<a href=\"/Food/AddFood\" class=\"btn btn-primary\">New Food</a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<CoreAndFood.Data.Models.Food>> Html { get; private set; }
    }
}
#pragma warning restore 1591
