#pragma checksum "D:\Filmi\Spice-master\Spice\Areas\Customer\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49e89acda654b99fa57d8910e423ad6245998869"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Customer/Views/Home/Index.cshtml")]
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
#line 1 "D:\Filmi\Spice-master\Spice\Areas\Customer\Views\_ViewImports.cshtml"
using Spice;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Filmi\Spice-master\Spice\Areas\Customer\Views\_ViewImports.cshtml"
using Spice.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49e89acda654b99fa57d8910e423ad6245998869", @"/Areas/Customer/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2c7dabcc8130653b90d3bc283b39b26d792e034", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Spice.Models.ViewModels.IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ThumbnailAreaPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<br />\n\n");
#nullable restore
#line 5 "D:\Filmi\Spice-master\Spice\Areas\Customer\Views\Home\Index.cshtml"
 if (Model.Coupon.ToList().Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"border\">\n        <div class=\"carousel\" data-ride=\"carousel\" data-interval=\"2500\">\n");
#nullable restore
#line 9 "D:\Filmi\Spice-master\Spice\Areas\Customer\Views\Home\Index.cshtml"
             for (int i = 0; i < Model.Coupon.Count(); i++)
            {
                if (i == 0)
                {



#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"carousel-item active\">\n");
#nullable restore
#line 16 "D:\Filmi\Spice-master\Spice\Areas\Customer\Views\Home\Index.cshtml"
                          
                            var base64 = Convert.ToBase64String(Model.Coupon.ToList()[i].Picture);
                            var imgsrc = string.Format("data:image/jpg;base64,{0}", base64);
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        <img");
            BeginWriteAttribute("src", " src=\"", 644, "\"", 657, 1);
#nullable restore
#line 21 "D:\Filmi\Spice-master\Spice\Areas\Customer\Views\Home\Index.cshtml"
WriteAttributeValue("", 650, imgsrc, 650, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"50px\" class=\"d-block w-100\" />\n                    </div>\n");
#nullable restore
#line 23 "D:\Filmi\Spice-master\Spice\Areas\Customer\Views\Home\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"carousel-item\">\n");
#nullable restore
#line 27 "D:\Filmi\Spice-master\Spice\Areas\Customer\Views\Home\Index.cshtml"
                          
                            var base64 = Convert.ToBase64String(Model.Coupon.ToList()[i].Picture);
                            var imgsrc = string.Format("data:image/jpg;base64,{0}", base64);
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        <img");
            BeginWriteAttribute("src", " src=\"", 1104, "\"", 1117, 1);
#nullable restore
#line 32 "D:\Filmi\Spice-master\Spice\Areas\Customer\Views\Home\Index.cshtml"
WriteAttributeValue("", 1110, imgsrc, 1110, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"50px\" class=\"d-block w-100\" />\n                    </div>\n");
#nullable restore
#line 34 "D:\Filmi\Spice-master\Spice\Areas\Customer\Views\Home\Index.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n    </div>\n");
#nullable restore
#line 38 "D:\Filmi\Spice-master\Spice\Areas\Customer\Views\Home\Index.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<br /><br />

      <div class=""backgroundWhite container"">
         
          <ul id=""menu-filters"" class=""menu-filter-list list-inline text-center"">
              <li class=""active btn btn-secondary ml-1 mr-1"" data-filter="".menu-restaurant"">Show All</li>

");
#nullable restore
#line 48 "D:\Filmi\Spice-master\Spice\Areas\Customer\Views\Home\Index.cshtml"
               foreach (var item in Model.Category)
              {

#line default
#line hidden
#nullable disable
            WriteLiteral("                  <li class=\"ml-1 mr-1\" data-filter=\".");
#nullable restore
#line 50 "D:\Filmi\Spice-master\Spice\Areas\Customer\Views\Home\Index.cshtml"
                                                 Write(item.Name.Replace(" ",string.Empty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 50 "D:\Filmi\Spice-master\Spice\Areas\Customer\Views\Home\Index.cshtml"
                                                                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 51 "D:\Filmi\Spice-master\Spice\Areas\Customer\Views\Home\Index.cshtml"
              }

#line default
#line hidden
#nullable disable
            WriteLiteral("          </ul>\n\n\n");
#nullable restore
#line 55 "D:\Filmi\Spice-master\Spice\Areas\Customer\Views\Home\Index.cshtml"
           foreach(var category in Model.Category)
          {

#line default
#line hidden
#nullable disable
            WriteLiteral("              <div class=\"row\" id=\"menu-wrapper\">\n                  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "49e89acda654b99fa57d8910e423ad62459988698244", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 58 "D:\Filmi\Spice-master\Spice\Areas\Customer\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.MenuItem.Where(u=>u.Category.Name.Equals(category.Name));

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n              </div>\n");
#nullable restore
#line 60 "D:\Filmi\Spice-master\Spice\Areas\Customer\Views\Home\Index.cshtml"
          }

#line default
#line hidden
#nullable disable
            WriteLiteral("      </div>\n\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@" 
      <script src=""https://code.jquery.com/jquery-3.3.1.js""
              integrity=""sha256-2Kok7MbOyxpgUVvAk/HJ2jigOSYS2auK4Pfzbm7uH60=""
              crossorigin=""anonymous""></script>

<script>

    var posts = $('.post');

    (function ($) {

        $(""#menu-filters li"").click(function () {
            $(""#menu-filters li"").removeClass('active btn btn-secondary');
            $(this).addClass('active btn btn-secondary');

            var selectedFilter = $(this).data(""filter"");

            $("".menu-restaurant"").fadeOut();

            setTimeout(function () {
                $(selectedFilter).slideDown();
            }, 300);
        });



    })(jQuery);
 
</script>
    ");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Spice.Models.ViewModels.IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
