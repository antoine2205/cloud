#pragma checksum "C:\Users\antoi\Desktop\RailDelay\RailDelay\Pages\Delays\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84ed7e276bdfb74d44bab5b047202d6d5ab87839"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RailDelay.Pages.Delays.Pages_Delays_Details), @"mvc.1.0.razor-page", @"/Pages/Delays/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Delays/Details.cshtml", typeof(RailDelay.Pages.Delays.Pages_Delays_Details), null)]
namespace RailDelay.Pages.Delays
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\antoi\Desktop\RailDelay\RailDelay\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\antoi\Desktop\RailDelay\RailDelay\Pages\_ViewImports.cshtml"
using RailDelay;

#line default
#line hidden
#line 3 "C:\Users\antoi\Desktop\RailDelay\RailDelay\Pages\_ViewImports.cshtml"
using RailDelay.Data;

#line default
#line hidden
#line 4 "C:\Users\antoi\Desktop\RailDelay\RailDelay\Pages\_ViewImports.cshtml"
using RailDelay.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84ed7e276bdfb74d44bab5b047202d6d5ab87839", @"/Pages/Delays/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0b016e525cf462ee836a2bde051c65005c31b95", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Delays_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\antoi\Desktop\RailDelay\RailDelay\Pages\Delays\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(96, 126, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Delay</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(223, 52, false);
#line 15 "C:\Users\antoi\Desktop\RailDelay\RailDelay\Pages\Delays\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Delay.TravelDate));

#line default
#line hidden
            EndContext();
            BeginContext(275, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(337, 48, false);
#line 18 "C:\Users\antoi\Desktop\RailDelay\RailDelay\Pages\Delays\Details.cshtml"
       Write(Html.DisplayFor(model => model.Delay.TravelDate));

#line default
#line hidden
            EndContext();
            BeginContext(385, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(446, 54, false);
#line 21 "C:\Users\antoi\Desktop\RailDelay\RailDelay\Pages\Delays\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Delay.TicketNumber));

#line default
#line hidden
            EndContext();
            BeginContext(500, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(562, 50, false);
#line 24 "C:\Users\antoi\Desktop\RailDelay\RailDelay\Pages\Delays\Details.cshtml"
       Write(Html.DisplayFor(model => model.Delay.TicketNumber));

#line default
#line hidden
            EndContext();
            BeginContext(612, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(673, 55, false);
#line 27 "C:\Users\antoi\Desktop\RailDelay\RailDelay\Pages\Delays\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Delay.LastDateOfUse));

#line default
#line hidden
            EndContext();
            BeginContext(728, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(790, 51, false);
#line 30 "C:\Users\antoi\Desktop\RailDelay\RailDelay\Pages\Delays\Details.cshtml"
       Write(Html.DisplayFor(model => model.Delay.LastDateOfUse));

#line default
#line hidden
            EndContext();
            BeginContext(841, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(902, 65, false);
#line 33 "C:\Users\antoi\Desktop\RailDelay\RailDelay\Pages\Delays\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Delay.DepartureTrainStationID));

#line default
#line hidden
            EndContext();
            BeginContext(967, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1029, 61, false);
#line 36 "C:\Users\antoi\Desktop\RailDelay\RailDelay\Pages\Delays\Details.cshtml"
       Write(Html.DisplayFor(model => model.Delay.DepartureTrainStationID));

#line default
#line hidden
            EndContext();
            BeginContext(1090, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1151, 67, false);
#line 39 "C:\Users\antoi\Desktop\RailDelay\RailDelay\Pages\Delays\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Delay.DestinationTrainStationID));

#line default
#line hidden
            EndContext();
            BeginContext(1218, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1280, 63, false);
#line 42 "C:\Users\antoi\Desktop\RailDelay\RailDelay\Pages\Delays\Details.cshtml"
       Write(Html.DisplayFor(model => model.Delay.DestinationTrainStationID));

#line default
#line hidden
            EndContext();
            BeginContext(1343, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1404, 64, false);
#line 45 "C:\Users\antoi\Desktop\RailDelay\RailDelay\Pages\Delays\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Delay.TransferTrainStationID));

#line default
#line hidden
            EndContext();
            BeginContext(1468, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1530, 60, false);
#line 48 "C:\Users\antoi\Desktop\RailDelay\RailDelay\Pages\Delays\Details.cshtml"
       Write(Html.DisplayFor(model => model.Delay.TransferTrainStationID));

#line default
#line hidden
            EndContext();
            BeginContext(1590, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1651, 62, false);
#line 51 "C:\Users\antoi\Desktop\RailDelay\RailDelay\Pages\Delays\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Delay.PlannedDepartureTime));

#line default
#line hidden
            EndContext();
            BeginContext(1713, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1775, 58, false);
#line 54 "C:\Users\antoi\Desktop\RailDelay\RailDelay\Pages\Delays\Details.cshtml"
       Write(Html.DisplayFor(model => model.Delay.PlannedDepartureTime));

#line default
#line hidden
            EndContext();
            BeginContext(1833, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1894, 60, false);
#line 57 "C:\Users\antoi\Desktop\RailDelay\RailDelay\Pages\Delays\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Delay.PlannedArrivalTime));

#line default
#line hidden
            EndContext();
            BeginContext(1954, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2016, 56, false);
#line 60 "C:\Users\antoi\Desktop\RailDelay\RailDelay\Pages\Delays\Details.cshtml"
       Write(Html.DisplayFor(model => model.Delay.PlannedArrivalTime));

#line default
#line hidden
            EndContext();
            BeginContext(2072, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2133, 61, false);
#line 63 "C:\Users\antoi\Desktop\RailDelay\RailDelay\Pages\Delays\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Delay.PlannedTrain1Number));

#line default
#line hidden
            EndContext();
            BeginContext(2194, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2256, 57, false);
#line 66 "C:\Users\antoi\Desktop\RailDelay\RailDelay\Pages\Delays\Details.cshtml"
       Write(Html.DisplayFor(model => model.Delay.PlannedTrain1Number));

#line default
#line hidden
            EndContext();
            BeginContext(2313, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2374, 61, false);
#line 69 "C:\Users\antoi\Desktop\RailDelay\RailDelay\Pages\Delays\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Delay.PlannedTrain2Number));

#line default
#line hidden
            EndContext();
            BeginContext(2435, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2497, 57, false);
#line 72 "C:\Users\antoi\Desktop\RailDelay\RailDelay\Pages\Delays\Details.cshtml"
       Write(Html.DisplayFor(model => model.Delay.PlannedTrain2Number));

#line default
#line hidden
            EndContext();
            BeginContext(2554, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2615, 61, false);
#line 75 "C:\Users\antoi\Desktop\RailDelay\RailDelay\Pages\Delays\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Delay.ActualDepartureTime));

#line default
#line hidden
            EndContext();
            BeginContext(2676, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2738, 57, false);
#line 78 "C:\Users\antoi\Desktop\RailDelay\RailDelay\Pages\Delays\Details.cshtml"
       Write(Html.DisplayFor(model => model.Delay.ActualDepartureTime));

#line default
#line hidden
            EndContext();
            BeginContext(2795, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2856, 59, false);
#line 81 "C:\Users\antoi\Desktop\RailDelay\RailDelay\Pages\Delays\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Delay.ActualArrivalTime));

#line default
#line hidden
            EndContext();
            BeginContext(2915, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2977, 55, false);
#line 84 "C:\Users\antoi\Desktop\RailDelay\RailDelay\Pages\Delays\Details.cshtml"
       Write(Html.DisplayFor(model => model.Delay.ActualArrivalTime));

#line default
#line hidden
            EndContext();
            BeginContext(3032, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3093, 60, false);
#line 87 "C:\Users\antoi\Desktop\RailDelay\RailDelay\Pages\Delays\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Delay.ActualTrain1Number));

#line default
#line hidden
            EndContext();
            BeginContext(3153, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3215, 56, false);
#line 90 "C:\Users\antoi\Desktop\RailDelay\RailDelay\Pages\Delays\Details.cshtml"
       Write(Html.DisplayFor(model => model.Delay.ActualTrain1Number));

#line default
#line hidden
            EndContext();
            BeginContext(3271, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3332, 60, false);
#line 93 "C:\Users\antoi\Desktop\RailDelay\RailDelay\Pages\Delays\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Delay.ActualTrain2Number));

#line default
#line hidden
            EndContext();
            BeginContext(3392, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3454, 56, false);
#line 96 "C:\Users\antoi\Desktop\RailDelay\RailDelay\Pages\Delays\Details.cshtml"
       Write(Html.DisplayFor(model => model.Delay.ActualTrain2Number));

#line default
#line hidden
            EndContext();
            BeginContext(3510, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3571, 48, false);
#line 99 "C:\Users\antoi\Desktop\RailDelay\RailDelay\Pages\Delays\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Delay.Ticket));

#line default
#line hidden
            EndContext();
            BeginContext(3619, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3681, 47, false);
#line 102 "C:\Users\antoi\Desktop\RailDelay\RailDelay\Pages\Delays\Details.cshtml"
       Write(Html.DisplayFor(model => model.Delay.Ticket.ID));

#line default
#line hidden
            EndContext();
            BeginContext(3728, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(3775, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84ed7e276bdfb74d44bab5b047202d6d5ab8783917331", async() => {
                BeginContext(3827, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 107 "C:\Users\antoi\Desktop\RailDelay\RailDelay\Pages\Delays\Details.cshtml"
                           WriteLiteral(Model.Delay.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3835, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(3843, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84ed7e276bdfb74d44bab5b047202d6d5ab8783919649", async() => {
                BeginContext(3865, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3881, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RailDelay.Pages.Delays.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RailDelay.Pages.Delays.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RailDelay.Pages.Delays.DetailsModel>)PageContext?.ViewData;
        public RailDelay.Pages.Delays.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
