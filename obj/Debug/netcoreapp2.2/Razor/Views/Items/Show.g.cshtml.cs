#pragma checksum "/Users/Guest/Desktop/tamagotchi/Tamagotchi/Views/Items/Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b93742af4cb99a95655c24de429f25809d78eb2f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_Show), @"mvc.1.0.view", @"/Views/Items/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Items/Show.cshtml", typeof(AspNetCore.Views_Items_Show))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b93742af4cb99a95655c24de429f25809d78eb2f", @"/Views/Items/Show.cshtml")]
    public class Views_Items_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 30, true);
            WriteLiteral("<h1>This is Tamagotchi: </h1>\n");
            EndContext();
            BeginContext(68, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(73, 15, false);
#line 4 "/Users/Guest/Desktop/tamagotchi/Tamagotchi/Views/Items/Show.cshtml"
Write(Model.GetName());

#line default
#line hidden
            EndContext();
            BeginContext(88, 25, true);
            WriteLiteral("</h2>\n<ul>\n<li>Happiness:");
            EndContext();
            BeginContext(114, 20, false);
#line 6 "/Users/Guest/Desktop/tamagotchi/Tamagotchi/Views/Items/Show.cshtml"
         Write(Model.GetHappiness());

#line default
#line hidden
            EndContext();
            BeginContext(134, 15, true);
            WriteLiteral("</li>\n<li>Poop:");
            EndContext();
            BeginContext(150, 15, false);
#line 7 "/Users/Guest/Desktop/tamagotchi/Tamagotchi/Views/Items/Show.cshtml"
    Write(Model.GetPoop());

#line default
#line hidden
            EndContext();
            BeginContext(165, 15, true);
            WriteLiteral("</li>\n<li>Rest:");
            EndContext();
            BeginContext(181, 15, false);
#line 8 "/Users/Guest/Desktop/tamagotchi/Tamagotchi/Views/Items/Show.cshtml"
    Write(Model.GetRest());

#line default
#line hidden
            EndContext();
            BeginContext(196, 17, true);
            WriteLiteral("</li>\n<li>Hunger:");
            EndContext();
            BeginContext(214, 17, false);
#line 9 "/Users/Guest/Desktop/tamagotchi/Tamagotchi/Views/Items/Show.cshtml"
      Write(Model.GetHunger());

#line default
#line hidden
            EndContext();
            BeginContext(231, 15, true);
            WriteLiteral("</li>\n<li>Food:");
            EndContext();
            BeginContext(247, 15, false);
#line 10 "/Users/Guest/Desktop/tamagotchi/Tamagotchi/Views/Items/Show.cshtml"
    Write(Model.GetFood());

#line default
#line hidden
            EndContext();
            BeginContext(262, 20, true);
            WriteLiteral("</li>\n<li>Attention:");
            EndContext();
            BeginContext(283, 20, false);
#line 11 "/Users/Guest/Desktop/tamagotchi/Tamagotchi/Views/Items/Show.cshtml"
         Write(Model.GetAttention());

#line default
#line hidden
            EndContext();
            BeginContext(303, 12, true);
            WriteLiteral("</li>\n</ul>\n");
            EndContext();
            BeginContext(392, 7, true);
            WriteLiteral("\n\n<form");
            EndContext();
            BeginWriteAttribute("action", " action=\"", 399, "\"", 429, 2);
            WriteAttributeValue("", 408, "/items/", 408, 7, true);
#line 18 "/Users/Guest/Desktop/tamagotchi/Tamagotchi/Views/Items/Show.cshtml"
WriteAttributeValue("", 415, Model.GetId(), 415, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(430, 118, true);
            WriteLiteral(" method=\"post\">\n</form>\n<a href=\'/items/new\'>Make a new Tamagotchi!</a>\n<a href=\'/items\'>View all Tamagotchi</a>\n<form");
            EndContext();
            BeginWriteAttribute("action", " action=\"", 548, "\"", 583, 3);
            WriteAttributeValue("", 557, "/items/", 557, 7, true);
#line 22 "/Users/Guest/Desktop/tamagotchi/Tamagotchi/Views/Items/Show.cshtml"
WriteAttributeValue("", 564, Model.GetId(), 564, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 578, "/feed", 578, 5, true);
            EndWriteAttribute();
            BeginContext(584, 111, true);
            WriteLiteral(" method=\"post\">\n  <button type=\"submit\" class=\"btn btn-dark\" name=\"feed\">Feed Tamagotchi</button>\n</form>\n<form");
            EndContext();
            BeginWriteAttribute("action", " action=\"", 695, "\"", 730, 3);
            WriteAttributeValue("", 704, "/items/", 704, 7, true);
#line 25 "/Users/Guest/Desktop/tamagotchi/Tamagotchi/Views/Items/Show.cshtml"
WriteAttributeValue("", 711, Model.GetId(), 711, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 725, "/rest", 725, 5, true);
            EndWriteAttribute();
            BeginContext(731, 120, true);
            WriteLiteral(" method=\"post\">\n  <button type=\"submit\" class=\"btn btn-danger\" name=\"rest\">Put to Rest Tamagotchi</button>\n</form>\n<form");
            EndContext();
            BeginWriteAttribute("action", " action=\"", 851, "\"", 891, 3);
            WriteAttributeValue("", 860, "/items/", 860, 7, true);
#line 28 "/Users/Guest/Desktop/tamagotchi/Tamagotchi/Views/Items/Show.cshtml"
WriteAttributeValue("", 867, Model.GetId(), 867, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 881, "/attention", 881, 10, true);
            EndWriteAttribute();
            BeginContext(892, 127, true);
            WriteLiteral(" method=\"post\">\n  <button type=\"submit\" class=\"btn btn-light\" name=\"attention\">Give Tamagotchi attention</button>\n</form>\n<form");
            EndContext();
            BeginWriteAttribute("action", " action=\"", 1019, "\"", 1054, 3);
            WriteAttributeValue("", 1028, "/items/", 1028, 7, true);
#line 31 "/Users/Guest/Desktop/tamagotchi/Tamagotchi/Views/Items/Show.cshtml"
WriteAttributeValue("", 1035, Model.GetId(), 1035, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 1049, "/poop", 1049, 5, true);
            EndWriteAttribute();
            BeginContext(1055, 118, true);
            WriteLiteral(" method=\"post\">\n  <button type=\"submit\" class=\"btn btn-warning\" name=\"poop\">Clean Poop of Tamagotchi</button>\n</form>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591