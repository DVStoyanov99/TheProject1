#pragma checksum "D:\Filmi\Spice-master\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "468c4f9d0708e7bb1cd1bbb439bef45701ea4e88"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Order_OrderPickup), @"mvc.1.0.view", @"/Areas/Customer/Views/Order/OrderPickup.cshtml")]
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
#nullable restore
#line 2 "D:\Filmi\Spice-master\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
using Spice.Utility;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"468c4f9d0708e7bb1cd1bbb439bef45701ea4e88", @"/Areas/Customer/Views/Order/OrderPickup.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2c7dabcc8130653b90d3bc283b39b26d792e034", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Order_OrderPickup : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Spice.Models.ViewModels.OrderListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class", "btn border", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-normal", "btn btn-light", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-selected", "btn btn-info active", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-group float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Spice.TagHelpers.PageLinkTagHelper __Spice_TagHelpers_PageLinkTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Filmi\Spice-master\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "468c4f9d0708e7bb1cd1bbb439bef45701ea4e885421", async() => {
                WriteLiteral(@"

    <br /><br />
    <h2 class=""text-info""> Orders Ready for Pickup : </h2>
    <div class=""border backgroundWhite"">
        <div class=""container border border-secondary"" style=""height:60px;"">
            <div class=""row container"">
                <div class=""col-11"">
                    <div class=""row"" style=""padding-top:10px"">
                        <div class=""col-4"">
                            ");
#nullable restore
#line 19 "D:\Filmi\Spice-master\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
                       Write(Html.Editor("searchName", new { htmlAttributes = new { @class = "form-control", @placeholder = "Name..." } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </div>\n                        <div class=\"col-4\">\n                            ");
#nullable restore
#line 22 "D:\Filmi\Spice-master\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
                       Write(Html.Editor("searchPhone", new { htmlAttributes = new { @class = "form-control", @placeholder = "Phone..." } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </div>\n                        <div class=\"col-4\">\n                            ");
#nullable restore
#line 25 "D:\Filmi\Spice-master\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
                       Write(Html.Editor("searchEmail", new { htmlAttributes = new { @class = "form-control", @placeholder = "Email..." } }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        </div>
                    </div>
                </div>
                <div class=""col-1"">
                    <div class=""row"" style=""padding-top:10px;"">
                        <button type=""submit"" name=""submit"" value=""Search"" class=""btn btn-info form-control"">
                            <i class=""fas fa-search""></i>
                        </button>
                    </div>
                </div>
            </div>

        </div>
        <br />
        <div>
");
#nullable restore
#line 41 "D:\Filmi\Spice-master\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
             if (Model.Orders.Count() > 0)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <table class=\"table table-striped border\">\n                    <tr class=\"table-secondary\">\n                        <th>\n                            ");
#nullable restore
#line 46 "D:\Filmi\Spice-master\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
                       Write(Html.DisplayNameFor(m => m.Orders[0].OrderHeader.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </th>\n                        <th>\n                            ");
#nullable restore
#line 49 "D:\Filmi\Spice-master\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
                       Write(Html.DisplayNameFor(m => m.Orders[0].OrderHeader.PickupName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </th>\n                        <th>\n                            ");
#nullable restore
#line 52 "D:\Filmi\Spice-master\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
                       Write(Html.DisplayNameFor(m => m.Orders[0].OrderHeader.ApplicationUser.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </th>\n                        <th>\n                            ");
#nullable restore
#line 55 "D:\Filmi\Spice-master\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
                       Write(Html.DisplayNameFor(m => m.Orders[0].OrderHeader.PickUpTime));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </th>\n                        <th>\n                            ");
#nullable restore
#line 58 "D:\Filmi\Spice-master\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
                       Write(Html.DisplayNameFor(m => m.Orders[0].OrderHeader.OrderTotal));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </th>\n                        <th>\n                            Total Items\n                        </th>\n                        <th></th>\n\n                    </tr>\n");
#nullable restore
#line 66 "D:\Filmi\Spice-master\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
                     foreach (var item in Model.Orders)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\n                            <td>\n                                ");
#nullable restore
#line 70 "D:\Filmi\Spice-master\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
                           Write(Html.DisplayFor(m => item.OrderHeader.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                            </td>\n                            <td>\n                                ");
#nullable restore
#line 73 "D:\Filmi\Spice-master\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
                           Write(Html.DisplayFor(m => item.OrderHeader.PickupName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                            </td>\n                            <td>\n                                ");
#nullable restore
#line 76 "D:\Filmi\Spice-master\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
                           Write(Html.DisplayFor(m => item.OrderHeader.ApplicationUser.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                            </td>\n                            <td>\n                                ");
#nullable restore
#line 79 "D:\Filmi\Spice-master\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
                           Write(Html.DisplayFor(m => item.OrderHeader.PickUpTime));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                            </td>\n                            <td>\n                                ");
#nullable restore
#line 82 "D:\Filmi\Spice-master\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
                           Write(Html.DisplayFor(m => item.OrderHeader.OrderTotal));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                            </td>\n                            <td>\n                                ");
#nullable restore
#line 85 "D:\Filmi\Spice-master\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
                           Write(Html.DisplayFor(m => item.OrderDetails.Count));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                            </td>\n                            <td>\n                                <button type=\"button\" class=\"btn btn-success anchorDetail\" data-id=\"");
#nullable restore
#line 88 "D:\Filmi\Spice-master\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
                                                                                               Write(item.OrderHeader.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" data-toggle=\"modal\">\n                                    <i class=\"far fa-list-alt\"></i> Details\n                                </button>\n\n                            </td>\n                        </tr>\n");
#nullable restore
#line 94 "D:\Filmi\Spice-master\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </table>\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "468c4f9d0708e7bb1cd1bbb439bef45701ea4e8813730", async() => {
                    WriteLiteral("\n                ");
                }
                );
                __Spice_TagHelpers_PageLinkTagHelper = CreateTagHelper<global::Spice.TagHelpers.PageLinkTagHelper>();
                __tagHelperExecutionContext.Add(__Spice_TagHelpers_PageLinkTagHelper);
#nullable restore
#line 96 "D:\Filmi\Spice-master\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
__Spice_TagHelpers_PageLinkTagHelper.PageModel = Model.PagingInfo;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("page-model", __Spice_TagHelpers_PageLinkTagHelper.PageModel, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 96 "D:\Filmi\Spice-master\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
__Spice_TagHelpers_PageLinkTagHelper.PageClassesEnabled = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("page-classes-enabled", __Spice_TagHelpers_PageLinkTagHelper.PageClassesEnabled, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Spice_TagHelpers_PageLinkTagHelper.PageClass = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Spice_TagHelpers_PageLinkTagHelper.PageClassNormal = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Spice_TagHelpers_PageLinkTagHelper.PageClassSelected = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                <br />\n");
#nullable restore
#line 101 "D:\Filmi\Spice-master\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <p>No category exists...</p>\n");
#nullable restore
#line 105 "D:\Filmi\Spice-master\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\n    </div>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
   
 <div class=""modal fade"" id=""myModal"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
        <div class=""modal-dialog-centered modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header bg-success text-light "">
                    <div class=""col-10 offset-1"">
                        <center><h5 class=""modal-title"">Order Details</h5></center>
                    </div>
                    <div class=""col-1"">
                        <button type=""button"" class=""float-right btn-outline-secondary close"" data-dismiss=""modal"" aria-label=""Close"">
                            <span aria-hidden=""true"">&times;</span>
                        </button>
                    </div>
                </div>
                <div class=""modal-body justify-content-center"" id=""myModalContent"">

                </div>
                
            </div>
        </div>
    </div>
   


");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        var PostBackURL = '/Customer/Order/GetOrderDetails';
       
        $(function () {
            $("".anchorDetail"").click(function () {

                var $buttonClicked = $(this);
                var id = $buttonClicked.attr('data-id');

                $.ajax({
                    type: ""GET"",
                    url: PostBackURL,
                    contentType: ""application/json; charset=utf-8"",
                    data: { ""Id"": id },
                    cache: false,
                    datatyype: ""json"",
                    success: function (data) {
                        $('#myModalContent').html(data);
                        $('#myModal').modal('show');
                    },
                    error: function () {
                        alert(""Dynamic content load failed"");
                    }
                });

            });

          
        });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Spice.Models.ViewModels.OrderListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
