#pragma checksum "F:\Дипломака\Project\Diplom\DiplomaWork\App.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e6ce71cd459ad5a58ac27dfbdf35dd260c5b2b0"
// <auto-generated/>
#pragma warning disable 1591
namespace DiplomaWork
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "F:\Дипломака\Project\Diplom\DiplomaWork\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Дипломака\Project\Diplom\DiplomaWork\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Дипломака\Project\Diplom\DiplomaWork\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Дипломака\Project\Diplom\DiplomaWork\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Дипломака\Project\Diplom\DiplomaWork\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Дипломака\Project\Diplom\DiplomaWork\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\Дипломака\Project\Diplom\DiplomaWork\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\Дипломака\Project\Diplom\DiplomaWork\_Imports.razor"
using DiplomaWork;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\Дипломака\Project\Diplom\DiplomaWork\_Imports.razor"
using DiplomaWork.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\Дипломака\Project\Diplom\DiplomaWork\_Imports.razor"
using DiplomaWork.Models;

#line default
#line hidden
#nullable disable
    public partial class App : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.Router>(0);
            __builder.AddAttribute(1, "AppAssembly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Reflection.Assembly>(
#nullable restore
#line 2 "F:\Дипломака\Project\Diplom\DiplomaWork\App.razor"
                      typeof(Program).Assembly

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Found", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.RouteData>)((routeData) => (__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.RouteView>(4);
                __builder2.AddAttribute(5, "RouteData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.RouteData>(
#nullable restore
#line 4 "F:\Дипломака\Project\Diplom\DiplomaWork\App.razor"
                               routeData

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(6, "DefaultLayout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 4 "F:\Дипломака\Project\Diplom\DiplomaWork\App.razor"
                                                          typeof(MainLayout)

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
            }
            ));
            __builder.AddAttribute(8, "NotFound", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.LayoutView>(10);
                __builder2.AddAttribute(11, "Layout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 7 "F:\Дипломака\Project\Diplom\DiplomaWork\App.razor"
                             typeof(EmptyLayout)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(13, "\r\n            <link rel=\"stylesheet\" href=\"/css/404page.css\">\r\n            ");
                    __builder3.OpenElement(14, "div");
                    __builder3.AddAttribute(15, "class", "container");
                    __builder3.AddMarkupContent(16, "\r\n                ");
                    __builder3.OpenElement(17, "div");
                    __builder3.AddAttribute(18, "class", "error");
                    __builder3.AddMarkupContent(19, "\r\n                    ");
                    __builder3.AddMarkupContent(20, "<p class=\"p\">4</p>\r\n                    ");
                    __builder3.AddMarkupContent(21, @"<div class=""dracula"">
                        <div class=""con"">
                            <div class=""hair""></div>
                            <div class=""hair-r""></div>
                            <div class=""head""></div>
                            <div class=""eye""></div>
                            <div class=""eye eye-r""></div>
                            <div class=""mouth""></div>
                            <div class=""blod""></div>
                            <div class=""blod blod2""></div>
                        </div>
                    </div>
                    ");
                    __builder3.AddMarkupContent(22, "<p class=\"p\">4</p>\r\n\r\n                    ");
                    __builder3.OpenElement(23, "div");
                    __builder3.AddAttribute(24, "class", "page-ms");
                    __builder3.AddMarkupContent(25, "\r\n                        ");
                    __builder3.AddMarkupContent(26, "<p class=\"page-msg\"> Oops, the page you\'re looking for Disappeared </p>\r\n                        ");
                    __builder3.OpenElement(27, "button");
                    __builder3.AddAttribute(28, "class", "go-back");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(29);
                    __builder3.AddAttribute(30, "href", "/");
                    __builder3.AddAttribute(31, "class", "back");
                    __builder3.AddAttribute(32, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(33, "Go Back");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(34, "\r\n                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(35, "\r\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(36, "\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(37, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(38, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591