#pragma checksum "F:\Дипломака\Project\Diplom\DiplomaWork\Pages\UserForms\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88d81c78a2b22d2298a21f15b943ef8aabd51a05"
// <auto-generated/>
#pragma warning disable 1591
namespace DiplomaWork.Pages.UserForms
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
#nullable restore
#line 11 "F:\Дипломака\Project\Diplom\DiplomaWork\_Imports.razor"
using Diplom.Shared.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "F:\Дипломака\Project\Diplom\DiplomaWork\_Imports.razor"
using DiplomaWork.Helpers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(EmptyLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link href=\"/css/autorize.css\" rel=\"stylesheet\">\r\n<link href=\"https://use.fontawesome.com/releases/v5.0.8/css/all.css\" rel=\"stylesheet\">\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container-fluid");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row justify-content-center text-center align-items-center bg-light");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-lg-6 col-xl-4 col-8 col-md-7 bg-white");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.AddMarkupContent(10, "<h1 class=\"display-4 mb-3 mt-3\">\r\n                Log in\r\n            </h1>\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(11);
            __builder.AddAttribute(12, "class", "text-lg-left text-md-center");
            __builder.AddAttribute(13, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 14 "F:\Дипломака\Project\Diplom\DiplomaWork\Pages\UserForms\Login.razor"
                                                                  _validation

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 14 "F:\Дипломака\Project\Diplom\DiplomaWork\Pages\UserForms\Login.razor"
                                                                                              OnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(15, "OnInvalidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 14 "F:\Дипломака\Project\Diplom\DiplomaWork\Pages\UserForms\Login.razor"
                                                                                                                              OnInvalidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(16, "novalidate", true);
            __builder.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(18, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(19);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\r\n                ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "row");
                __builder2.AddMarkupContent(23, "\r\n                    ");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "col-12 mt-3");
                __builder2.AddMarkupContent(26, "\r\n                        ");
                __builder2.AddMarkupContent(27, "<label for=\"email\">Email</label>\r\n                        ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "input-group");
                __builder2.AddMarkupContent(30, "\r\n                            ");
                __builder2.AddMarkupContent(31, "<div class=\"input-group-prepend\">\r\n                                <span class=\"input-group-text\"><i class=\"fas fa-at\"></i></span>\r\n                            </div>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(32);
                __builder2.AddAttribute(33, "type", "email");
                __builder2.AddAttribute(34, "class", "form-control");
                __builder2.AddAttribute(35, "id", "email");
                __builder2.AddAttribute(36, "placeholder", "you@example.com");
                __builder2.AddAttribute(37, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "F:\Дипломака\Project\Diplom\DiplomaWork\Pages\UserForms\Login.razor"
                                                                                      _validation.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _validation.Email = __value, _validation.Email))));
                __builder2.AddAttribute(39, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _validation.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(40, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n                ");
                __Blazor.DiplomaWork.Pages.UserForms.Login.TypeInference.CreateValidationMessage_0(__builder2, 44, 45, 
#nullable restore
#line 27 "F:\Дипломака\Project\Diplom\DiplomaWork\Pages\UserForms\Login.razor"
                                          () => @_validation.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(46, "\r\n                ");
                __builder2.OpenElement(47, "div");
                __builder2.AddAttribute(48, "class", "row");
                __builder2.AddMarkupContent(49, "\r\n                    ");
                __builder2.OpenElement(50, "div");
                __builder2.AddAttribute(51, "class", "col-12 mt-3");
                __builder2.AddMarkupContent(52, "\r\n                        ");
                __builder2.AddMarkupContent(53, "<label for=\"password\">Password</label>\r\n                        ");
                __builder2.OpenElement(54, "div");
                __builder2.AddAttribute(55, "class", "input-group");
                __builder2.AddMarkupContent(56, "\r\n                            ");
                __builder2.AddMarkupContent(57, "<div class=\"input-group-prepend\">\r\n                                <span class=\"input-group-text\"><i class=\"fas fa-key\"></i></span>\r\n                            </div>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(58);
                __builder2.AddAttribute(59, "type", "password");
                __builder2.AddAttribute(60, "class", "form-control");
                __builder2.AddAttribute(61, "id", "password");
                __builder2.AddAttribute(62, "placeholder", "********");
                __builder2.AddAttribute(63, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 35 "F:\Дипломака\Project\Diplom\DiplomaWork\Pages\UserForms\Login.razor"
                                                                                         _validation.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(64, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _validation.Password = __value, _validation.Password))));
                __builder2.AddAttribute(65, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _validation.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(66, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n                ");
                __Blazor.DiplomaWork.Pages.UserForms.Login.TypeInference.CreateValidationMessage_1(__builder2, 70, 71, 
#nullable restore
#line 39 "F:\Дипломака\Project\Diplom\DiplomaWork\Pages\UserForms\Login.razor"
                                          () => @_validation.Password

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(72, "\r\n                ");
                __builder2.AddMarkupContent(73, @"<div class=""row justify-content-center mx-auto"">
                    <div class=""col-6 mb-4 mt-3 text-center"">
                        <button class=""btn btn-primary btn-lg btn-block"" type=""submit"">Login</button>
                    </div>
                </div>
            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(74, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "F:\Дипломака\Project\Diplom\DiplomaWork\Pages\UserForms\Login.razor"
       
    UserModel _validation = new UserModel();

    private void OnValidSubmit()
    {
        Console.WriteLine("Submit Valid");
    }

    private void OnInvalidSubmit()
    {
        Console.WriteLine("Submit Invalid");
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.DiplomaWork.Pages.UserForms.Login
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
