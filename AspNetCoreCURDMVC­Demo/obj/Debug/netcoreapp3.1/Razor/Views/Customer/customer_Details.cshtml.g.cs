#pragma checksum "C:\Users\91865\Desktop\AspNetCoreApi\AspNetCoreCURDMVC­Demo\AspNetCoreCURDMVC­Demo\Views\Customer\customer_Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a44df86245099685e11e0426c111e12b274efe7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_customer_Details), @"mvc.1.0.view", @"/Views/Customer/customer_Details.cshtml")]
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
#line 1 "C:\Users\91865\Desktop\AspNetCoreApi\AspNetCoreCURDMVC­Demo\AspNetCoreCURDMVC­Demo\Views\_ViewImports.cshtml"
using AspNetCoreCURDMVC_Demo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\91865\Desktop\AspNetCoreApi\AspNetCoreCURDMVC­Demo\AspNetCoreCURDMVC­Demo\Views\_ViewImports.cshtml"
using AspNetCoreCURDMVC_Demo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a44df86245099685e11e0426c111e12b274efe7", @"/Views/Customer/customer_Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18f63fbb085773775c56962992918d446394d1e6", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_customer_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AspNetCoreCURDMVC_Demo.Models.Customer>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\91865\Desktop\AspNetCoreApi\AspNetCoreCURDMVC­Demo\AspNetCoreCURDMVC­Demo\Views\Customer\customer_Details.cshtml"
  
    ViewData["Title"] = "customer_Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>Customer Details</h3>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 13 "C:\Users\91865\Desktop\AspNetCoreApi\AspNetCoreCURDMVC­Demo\AspNetCoreCURDMVC­Demo\Views\Customer\customer_Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 16 "C:\Users\91865\Desktop\AspNetCoreApi\AspNetCoreCURDMVC­Demo\AspNetCoreCURDMVC­Demo\Views\Customer\customer_Details.cshtml"
       Write(Html.DisplayFor(model => model.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 19 "C:\Users\91865\Desktop\AspNetCoreApi\AspNetCoreCURDMVC­Demo\AspNetCoreCURDMVC­Demo\Views\Customer\customer_Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 22 "C:\Users\91865\Desktop\AspNetCoreApi\AspNetCoreCURDMVC­Demo\AspNetCoreCURDMVC­Demo\Views\Customer\customer_Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 25 "C:\Users\91865\Desktop\AspNetCoreApi\AspNetCoreCURDMVC­Demo\AspNetCoreCURDMVC­Demo\Views\Customer\customer_Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 28 "C:\Users\91865\Desktop\AspNetCoreApi\AspNetCoreCURDMVC­Demo\AspNetCoreCURDMVC­Demo\Views\Customer\customer_Details.cshtml"
       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 31 "C:\Users\91865\Desktop\AspNetCoreApi\AspNetCoreCURDMVC­Demo\AspNetCoreCURDMVC­Demo\Views\Customer\customer_Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 34 "C:\Users\91865\Desktop\AspNetCoreApi\AspNetCoreCURDMVC­Demo\AspNetCoreCURDMVC­Demo\Views\Customer\customer_Details.cshtml"
       Write(Html.DisplayFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 37 "C:\Users\91865\Desktop\AspNetCoreApi\AspNetCoreCURDMVC­Demo\AspNetCoreCURDMVC­Demo\Views\Customer\customer_Details.cshtml"
       Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 40 "C:\Users\91865\Desktop\AspNetCoreApi\AspNetCoreCURDMVC­Demo\AspNetCoreCURDMVC­Demo\Views\Customer\customer_Details.cshtml"
       Write(Html.DisplayFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 43 "C:\Users\91865\Desktop\AspNetCoreApi\AspNetCoreCURDMVC­Demo\AspNetCoreCURDMVC­Demo\Views\Customer\customer_Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 46 "C:\Users\91865\Desktop\AspNetCoreApi\AspNetCoreCURDMVC­Demo\AspNetCoreCURDMVC­Demo\Views\Customer\customer_Details.cshtml"
       Write(Html.DisplayFor(model => model.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 49 "C:\Users\91865\Desktop\AspNetCoreApi\AspNetCoreCURDMVC­Demo\AspNetCoreCURDMVC­Demo\Views\Customer\customer_Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Mobile));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 52 "C:\Users\91865\Desktop\AspNetCoreApi\AspNetCoreCURDMVC­Demo\AspNetCoreCURDMVC­Demo\Views\Customer\customer_Details.cshtml"
       Write(Html.DisplayFor(model => model.Mobile));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 55 "C:\Users\91865\Desktop\AspNetCoreApi\AspNetCoreCURDMVC­Demo\AspNetCoreCURDMVC­Demo\Views\Customer\customer_Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 58 "C:\Users\91865\Desktop\AspNetCoreApi\AspNetCoreCURDMVC­Demo\AspNetCoreCURDMVC­Demo\Views\Customer\customer_Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 63 "C:\Users\91865\Desktop\AspNetCoreApi\AspNetCoreCURDMVC­Demo\AspNetCoreCURDMVC­Demo\Views\Customer\customer_Details.cshtml"
Write(Html.ActionLink("Edit", "Edit_customer", new {id = Model.ID}, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a44df86245099685e11e0426c111e12b274efe710103", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AspNetCoreCURDMVC_Demo.Models.Customer> Html { get; private set; }
    }
}
#pragma warning restore 1591
