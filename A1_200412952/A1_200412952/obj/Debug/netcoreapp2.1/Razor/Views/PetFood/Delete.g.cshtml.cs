#pragma checksum "C:\Users\Kiril Mankovskyi\Desktop\Semester 3\Server-Side Scripting-ASP.NET\A1_200412952\A1_200412952\A1_200412952\Views\PetFood\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56f3d2e87cab20b5e9efa779f142ac65e2214c64"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PetFood_Delete), @"mvc.1.0.view", @"/Views/PetFood/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PetFood/Delete.cshtml", typeof(AspNetCore.Views_PetFood_Delete))]
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
#line 1 "C:\Users\Kiril Mankovskyi\Desktop\Semester 3\Server-Side Scripting-ASP.NET\A1_200412952\A1_200412952\A1_200412952\Views\_ViewImports.cshtml"
using A1_200412952;

#line default
#line hidden
#line 2 "C:\Users\Kiril Mankovskyi\Desktop\Semester 3\Server-Side Scripting-ASP.NET\A1_200412952\A1_200412952\A1_200412952\Views\_ViewImports.cshtml"
using A1_200412952.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56f3d2e87cab20b5e9efa779f142ac65e2214c64", @"/Views/PetFood/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a072499e2511d080d77fa64500f66ec4a357fd25", @"/Views/_ViewImports.cshtml")]
    public class Views_PetFood_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<A1_200412952.Models.Pet_Food>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Kiril Mankovskyi\Desktop\Semester 3\Server-Side Scripting-ASP.NET\A1_200412952\A1_200412952\A1_200412952\Views\PetFood\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(81, 169, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Pet_Food</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(251, 41, false);
#line 15 "C:\Users\Kiril Mankovskyi\Desktop\Semester 3\Server-Side Scripting-ASP.NET\A1_200412952\A1_200412952\A1_200412952\Views\PetFood\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(292, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(336, 37, false);
#line 18 "C:\Users\Kiril Mankovskyi\Desktop\Semester 3\Server-Side Scripting-ASP.NET\A1_200412952\A1_200412952\A1_200412952\Views\PetFood\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(373, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(417, 40, false);
#line 21 "C:\Users\Kiril Mankovskyi\Desktop\Semester 3\Server-Side Scripting-ASP.NET\A1_200412952\A1_200412952\A1_200412952\Views\PetFood\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(457, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(501, 36, false);
#line 24 "C:\Users\Kiril Mankovskyi\Desktop\Semester 3\Server-Side Scripting-ASP.NET\A1_200412952\A1_200412952\A1_200412952\Views\PetFood\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(537, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(581, 47, false);
#line 27 "C:\Users\Kiril Mankovskyi\Desktop\Semester 3\Server-Side Scripting-ASP.NET\A1_200412952\A1_200412952\A1_200412952\Views\PetFood\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(628, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(672, 43, false);
#line 30 "C:\Users\Kiril Mankovskyi\Desktop\Semester 3\Server-Side Scripting-ASP.NET\A1_200412952\A1_200412952\A1_200412952\Views\PetFood\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(715, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(759, 59, false);
#line 33 "C:\Users\Kiril Mankovskyi\Desktop\Semester 3\Server-Side Scripting-ASP.NET\A1_200412952\A1_200412952\A1_200412952\Views\PetFood\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Nutritional_Information));

#line default
#line hidden
            EndContext();
            BeginContext(818, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(862, 55, false);
#line 36 "C:\Users\Kiril Mankovskyi\Desktop\Semester 3\Server-Side Scripting-ASP.NET\A1_200412952\A1_200412952\A1_200412952\Views\PetFood\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Nutritional_Information));

#line default
#line hidden
            EndContext();
            BeginContext(917, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(961, 42, false);
#line 39 "C:\Users\Kiril Mankovskyi\Desktop\Semester 3\Server-Side Scripting-ASP.NET\A1_200412952\A1_200412952\A1_200412952\Views\PetFood\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Weight));

#line default
#line hidden
            EndContext();
            BeginContext(1003, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1047, 38, false);
#line 42 "C:\Users\Kiril Mankovskyi\Desktop\Semester 3\Server-Side Scripting-ASP.NET\A1_200412952\A1_200412952\A1_200412952\Views\PetFood\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Weight));

#line default
#line hidden
            EndContext();
            BeginContext(1085, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1129, 41, false);
#line 45 "C:\Users\Kiril Mankovskyi\Desktop\Semester 3\Server-Side Scripting-ASP.NET\A1_200412952\A1_200412952\A1_200412952\Views\PetFood\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Brand));

#line default
#line hidden
            EndContext();
            BeginContext(1170, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1214, 37, false);
#line 48 "C:\Users\Kiril Mankovskyi\Desktop\Semester 3\Server-Side Scripting-ASP.NET\A1_200412952\A1_200412952\A1_200412952\Views\PetFood\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Brand));

#line default
#line hidden
            EndContext();
            BeginContext(1251, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1295, 50, false);
#line 51 "C:\Users\Kiril Mankovskyi\Desktop\Semester 3\Server-Side Scripting-ASP.NET\A1_200412952\A1_200412952\A1_200412952\Views\PetFood\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Type_Of_Animal));

#line default
#line hidden
            EndContext();
            BeginContext(1345, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1389, 46, false);
#line 54 "C:\Users\Kiril Mankovskyi\Desktop\Semester 3\Server-Side Scripting-ASP.NET\A1_200412952\A1_200412952\A1_200412952\Views\PetFood\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Type_Of_Animal));

#line default
#line hidden
            EndContext();
            BeginContext(1435, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1473, 207, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33e1d747dcde4a9293800fb573a048eb", async() => {
                BeginContext(1499, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1509, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d16e1d9fb7e94cc4b66b0f4e55dc549d", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 59 "C:\Users\Kiril Mankovskyi\Desktop\Semester 3\Server-Side Scripting-ASP.NET\A1_200412952\A1_200412952\A1_200412952\Views\PetFood\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1545, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(1629, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "361ecff415494cd0b5df5dcc45195142", async() => {
                    BeginContext(1651, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1667, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1680, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<A1_200412952.Models.Pet_Food> Html { get; private set; }
    }
}
#pragma warning restore 1591
