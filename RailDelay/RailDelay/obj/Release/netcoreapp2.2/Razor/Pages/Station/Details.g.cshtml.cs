#pragma checksum "C:\Users\moena\source\repos\RailDelay\RailDelay\Pages\Station\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6fc1c4dfce1db34b8a671af5a08a7329c6c41a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RailDelay.Pages.Station.Pages_Station_Details), @"mvc.1.0.razor-page", @"/Pages/Station/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Station/Details.cshtml", typeof(RailDelay.Pages.Station.Pages_Station_Details), null)]
namespace RailDelay.Pages.Station
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\moena\source\repos\RailDelay\RailDelay\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\moena\source\repos\RailDelay\RailDelay\Pages\_ViewImports.cshtml"
using RailDelay;

#line default
#line hidden
#line 3 "C:\Users\moena\source\repos\RailDelay\RailDelay\Pages\_ViewImports.cshtml"
using RailDelay.Data;

#line default
#line hidden
#line 4 "C:\Users\moena\source\repos\RailDelay\RailDelay\Pages\_ViewImports.cshtml"
using RailDelay.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6fc1c4dfce1db34b8a671af5a08a7329c6c41a1", @"/Pages/Station/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0b016e525cf462ee836a2bde051c65005c31b95", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Station_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("imageThumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\moena\source\repos\RailDelay\RailDelay\Pages\Station\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(95, 114, true);
            WriteLiteral("\r\n<div>\r\n    <h4>Train station</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(210, 46, false);
#line 12 "C:\Users\moena\source\repos\RailDelay\RailDelay\Pages\Station\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Station.ID));

#line default
#line hidden
            EndContext();
            BeginContext(256, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(318, 42, false);
#line 15 "C:\Users\moena\source\repos\RailDelay\RailDelay\Pages\Station\Details.cshtml"
       Write(Html.DisplayFor(model => model.Station.ID));

#line default
#line hidden
            EndContext();
            BeginContext(360, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(421, 48, false);
#line 18 "C:\Users\moena\source\repos\RailDelay\RailDelay\Pages\Station\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Station.Name));

#line default
#line hidden
            EndContext();
            BeginContext(469, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(531, 44, false);
#line 21 "C:\Users\moena\source\repos\RailDelay\RailDelay\Pages\Station\Details.cshtml"
       Write(Html.DisplayFor(model => model.Station.Name));

#line default
#line hidden
            EndContext();
            BeginContext(575, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(636, 53, false);
#line 24 "C:\Users\moena\source\repos\RailDelay\RailDelay\Pages\Station\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Station.LocationX));

#line default
#line hidden
            EndContext();
            BeginContext(689, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(751, 49, false);
#line 27 "C:\Users\moena\source\repos\RailDelay\RailDelay\Pages\Station\Details.cshtml"
       Write(Html.DisplayFor(model => model.Station.LocationX));

#line default
#line hidden
            EndContext();
            BeginContext(800, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(861, 53, false);
#line 30 "C:\Users\moena\source\repos\RailDelay\RailDelay\Pages\Station\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Station.LocationY));

#line default
#line hidden
            EndContext();
            BeginContext(914, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(976, 49, false);
#line 33 "C:\Users\moena\source\repos\RailDelay\RailDelay\Pages\Station\Details.cshtml"
       Write(Html.DisplayFor(model => model.Station.LocationY));

#line default
#line hidden
            EndContext();
            BeginContext(1025, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1086, 47, false);
#line 36 "C:\Users\moena\source\repos\RailDelay\RailDelay\Pages\Station\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Station.URL));

#line default
#line hidden
            EndContext();
            BeginContext(1133, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1195, 43, false);
#line 39 "C:\Users\moena\source\repos\RailDelay\RailDelay\Pages\Station\Details.cshtml"
       Write(Html.DisplayFor(model => model.Station.URL));

#line default
#line hidden
            EndContext();
            BeginContext(1238, 183, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Picture\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            <div class=\"form-group row col-sm-4\">\r\n                ");
            EndContext();
            BeginContext(1421, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e6fc1c4dfce1db34b8a671af5a08a7329c6c41a18967", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
#line 46 "C:\Users\moena\source\repos\RailDelay\RailDelay\Pages\Station\Details.cshtml"
              WriteLiteral(Model.UrlPictureStation);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 46 "C:\Users\moena\source\repos\RailDelay\RailDelay\Pages\Station\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1508, 107, true);
            WriteLiteral("\r\n            </div>\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <!-- <a asp-page=\"./Edit\" asp-route-id=\"");
            EndContext();
            BeginContext(1616, 16, false);
#line 52 "C:\Users\moena\source\repos\RailDelay\RailDelay\Pages\Station\Details.cshtml"
                                       Write(Model.Station.ID);

#line default
#line hidden
            EndContext();
            BeginContext(1632, 22, true);
            WriteLiteral("\">Edit</a> | -->\r\n    ");
            EndContext();
            BeginContext(1654, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6fc1c4dfce1db34b8a671af5a08a7329c6c41a111639", async() => {
                BeginContext(1676, 12, true);
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
            BeginContext(1692, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1722, 257, true);
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $("".imageThumbnail"").on(""error"", function(){
                $("".imageThumbnail"").attr('src', './../images/image-not-available-hi.png');
            });
        });
    </script>
    ");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RailDelay.Pages.Station.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RailDelay.Pages.Station.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RailDelay.Pages.Station.DetailsModel>)PageContext?.ViewData;
        public RailDelay.Pages.Station.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591