#pragma checksum "F:\Дипломака\Project\Diplom\DiplomaWork\Pages\UserForms\Registration.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "563fd045c0b078b5934ce6d6639ff51cb6cb6716"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/registration")]
    public partial class Registration : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link href=\"/css/autorize.css\" rel=\"stylesheet\">\r\n<link href=\"https://use.fontawesome.com/releases/v5.0.8/css/all.css\" rel=\"stylesheet\">\r\n\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container-fluid");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row justify-content-center text-center align-items-center bg-light");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-lg-6 col-xl-4 col-8 col-md-7 bg-white");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.AddMarkupContent(10, "<h1 class=\"display-4 mb-2 mt-1\">\r\n                Sign Up\r\n            </h1>\r\n\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(11);
            __builder.AddAttribute(12, "class", "text-lg-left text-md-center");
            __builder.AddAttribute(13, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 15 "F:\Дипломака\Project\Diplom\DiplomaWork\Pages\UserForms\Registration.razor"
                                                                  _validation

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 15 "F:\Дипломака\Project\Diplom\DiplomaWork\Pages\UserForms\Registration.razor"
                                                                                              OnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(15, "OnInvalidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 15 "F:\Дипломака\Project\Diplom\DiplomaWork\Pages\UserForms\Registration.razor"
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
                __builder2.AddAttribute(25, "class", "col-lg-6 col-md-12 mt-2");
                __builder2.AddMarkupContent(26, "\r\n                        ");
                __builder2.AddMarkupContent(27, "<label for=\"name\">First Name</label>\r\n                        ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "input-group");
                __builder2.AddMarkupContent(30, "\r\n                            ");
                __builder2.AddMarkupContent(31, "<div class=\"input-group-prepend\">\r\n                                <span class=\"input-group-text\"><i class=\"far fa-id-badge\"></i></span>\r\n                            </div>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(32);
                __builder2.AddAttribute(33, "type", "text");
                __builder2.AddAttribute(34, "class", "form-control");
                __builder2.AddAttribute(35, "id", "name");
                __builder2.AddAttribute(36, "placeholder", "First Name");
                __builder2.AddAttribute(37, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "F:\Дипломака\Project\Diplom\DiplomaWork\Pages\UserForms\Registration.razor"
                                                                                     _validation.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _validation.FirstName = __value, _validation.FirstName))));
                __builder2.AddAttribute(39, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _validation.FirstName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(40, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n                        ");
                __Blazor.DiplomaWork.Pages.UserForms.Registration.TypeInference.CreateValidationMessage_0(__builder2, 42, 43, 
#nullable restore
#line 26 "F:\Дипломака\Project\Diplom\DiplomaWork\Pages\UserForms\Registration.razor"
                                                  () => @_validation.FirstName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(44, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n                    ");
                __builder2.OpenElement(46, "div");
                __builder2.AddAttribute(47, "class", "col-lg-6 col-md-12 mt-2");
                __builder2.AddMarkupContent(48, "\r\n                        ");
                __builder2.AddMarkupContent(49, "<label for=\"surname\">Last Name</label>\r\n                        ");
                __builder2.OpenElement(50, "div");
                __builder2.AddAttribute(51, "class", "input-group");
                __builder2.AddMarkupContent(52, "\r\n                            ");
                __builder2.AddMarkupContent(53, "<div class=\"input-group-prepend\">\r\n                                <span class=\"input-group-text\"><i class=\"fas fa-id-badge\"></i></span>\r\n                            </div>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(54);
                __builder2.AddAttribute(55, "type", "text");
                __builder2.AddAttribute(56, "class", "form-control");
                __builder2.AddAttribute(57, "id", "surname");
                __builder2.AddAttribute(58, "placeholder", "Last Name");
                __builder2.AddAttribute(59, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 34 "F:\Дипломака\Project\Diplom\DiplomaWork\Pages\UserForms\Registration.razor"
                                                                                     _validation.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(60, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _validation.LastName = __value, _validation.LastName))));
                __builder2.AddAttribute(61, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _validation.LastName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(62, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n                        ");
                __Blazor.DiplomaWork.Pages.UserForms.Registration.TypeInference.CreateValidationMessage_1(__builder2, 64, 65, 
#nullable restore
#line 36 "F:\Дипломака\Project\Diplom\DiplomaWork\Pages\UserForms\Registration.razor"
                                                  () => @_validation.LastName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(66, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n                ");
                __builder2.OpenElement(69, "div");
                __builder2.AddAttribute(70, "class", "row");
                __builder2.AddMarkupContent(71, "\r\n                    ");
                __builder2.OpenElement(72, "div");
                __builder2.AddAttribute(73, "class", "col-12 mt-2");
                __builder2.AddMarkupContent(74, "\r\n                        ");
                __builder2.AddMarkupContent(75, "<label for=\"username\">Username</label>\r\n                        ");
                __builder2.OpenElement(76, "div");
                __builder2.AddAttribute(77, "class", "input-group");
                __builder2.AddMarkupContent(78, "\r\n                            ");
                __builder2.AddMarkupContent(79, "<div class=\"input-group-prepend\">\r\n                                <span class=\"input-group-text\"><i class=\"fas fa-user-circle\"></i></span>\r\n                            </div>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(80);
                __builder2.AddAttribute(81, "type", "text");
                __builder2.AddAttribute(82, "class", "form-control");
                __builder2.AddAttribute(83, "id", "username");
                __builder2.AddAttribute(84, "placeholder", "Username");
                __builder2.AddAttribute(85, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 46 "F:\Дипломака\Project\Diplom\DiplomaWork\Pages\UserForms\Registration.razor"
                                                                                     _validation.Username

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(86, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _validation.Username = __value, _validation.Username))));
                __builder2.AddAttribute(87, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _validation.Username));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(88, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(89, "\r\n                        ");
                __Blazor.DiplomaWork.Pages.UserForms.Registration.TypeInference.CreateValidationMessage_2(__builder2, 90, 91, 
#nullable restore
#line 48 "F:\Дипломака\Project\Diplom\DiplomaWork\Pages\UserForms\Registration.razor"
                                                  () => @_validation.Username

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(92, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(93, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(94, "\r\n                ");
                __builder2.OpenElement(95, "div");
                __builder2.AddAttribute(96, "class", "row");
                __builder2.AddMarkupContent(97, "\r\n                    ");
                __builder2.OpenElement(98, "div");
                __builder2.AddAttribute(99, "class", "col-12 mt-2");
                __builder2.AddMarkupContent(100, "\r\n                        ");
                __builder2.AddMarkupContent(101, "<label for=\"email\">Email</label>\r\n                        ");
                __builder2.OpenElement(102, "div");
                __builder2.AddAttribute(103, "class", "input-group");
                __builder2.AddMarkupContent(104, "\r\n                            ");
                __builder2.AddMarkupContent(105, "<div class=\"input-group-prepend\">\r\n                                <span class=\"input-group-text\"><i class=\"fas fa-at\"></i></span>\r\n                            </div>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(106);
                __builder2.AddAttribute(107, "type", "text");
                __builder2.AddAttribute(108, "class", "form-control");
                __builder2.AddAttribute(109, "id", "email");
                __builder2.AddAttribute(110, "placeholder", "Email");
                __builder2.AddAttribute(111, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 58 "F:\Дипломака\Project\Diplom\DiplomaWork\Pages\UserForms\Registration.razor"
                                                                                     _validation.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(112, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _validation.Email = __value, _validation.Email))));
                __builder2.AddAttribute(113, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _validation.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(114, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(115, "\r\n                        ");
                __Blazor.DiplomaWork.Pages.UserForms.Registration.TypeInference.CreateValidationMessage_3(__builder2, 116, 117, 
#nullable restore
#line 60 "F:\Дипломака\Project\Diplom\DiplomaWork\Pages\UserForms\Registration.razor"
                                                  () => @_validation.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(118, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(119, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(120, "\r\n                ");
                __builder2.OpenElement(121, "div");
                __builder2.AddAttribute(122, "class", "row");
                __builder2.AddMarkupContent(123, "\r\n                    ");
                __builder2.OpenElement(124, "div");
                __builder2.AddAttribute(125, "class", "col-12 mt-2");
                __builder2.AddMarkupContent(126, "\r\n                        ");
                __builder2.AddMarkupContent(127, "<label for=\"password\">Password</label>\r\n                        ");
                __builder2.OpenElement(128, "div");
                __builder2.AddAttribute(129, "class", "input-group");
                __builder2.AddMarkupContent(130, "\r\n                            ");
                __builder2.AddMarkupContent(131, "<div class=\"input-group-prepend\">\r\n                                <span class=\"input-group-text\"><i class=\"fas fa-key\"></i></span>\r\n                            </div>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(132);
                __builder2.AddAttribute(133, "type", "password");
                __builder2.AddAttribute(134, "class", "form-control");
                __builder2.AddAttribute(135, "id", "password");
                __builder2.AddAttribute(136, "placeholder", "********");
                __builder2.AddAttribute(137, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 70 "F:\Дипломака\Project\Diplom\DiplomaWork\Pages\UserForms\Registration.razor"
                                                                                         _validation.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(138, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _validation.Password = __value, _validation.Password))));
                __builder2.AddAttribute(139, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _validation.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(140, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(141, "\r\n                        ");
                __Blazor.DiplomaWork.Pages.UserForms.Registration.TypeInference.CreateValidationMessage_4(__builder2, 142, 143, 
#nullable restore
#line 72 "F:\Дипломака\Project\Diplom\DiplomaWork\Pages\UserForms\Registration.razor"
                                                  () => @_validation.Password

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(144, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(145, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(146, "\r\n                ");
                __builder2.OpenElement(147, "div");
                __builder2.AddAttribute(148, "class", "row");
                __builder2.AddMarkupContent(149, "\r\n                    ");
                __builder2.OpenElement(150, "div");
                __builder2.AddAttribute(151, "class", "col-12 mt-2");
                __builder2.AddMarkupContent(152, "\r\n                        ");
                __builder2.AddMarkupContent(153, "<label for=\"c-password\">Confirm Password</label>\r\n                        ");
                __builder2.OpenElement(154, "div");
                __builder2.AddAttribute(155, "class", "input-group");
                __builder2.AddMarkupContent(156, "\r\n                            ");
                __builder2.AddMarkupContent(157, "<div class=\"input-group-prepend\">\r\n                                <span class=\"input-group-text\"><i class=\"fas fa-key\"></i></span>\r\n                            </div>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(158);
                __builder2.AddAttribute(159, "type", "password");
                __builder2.AddAttribute(160, "class", "form-control");
                __builder2.AddAttribute(161, "id", "c-passwor");
                __builder2.AddAttribute(162, "placeholder", "********");
                __builder2.AddAttribute(163, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 82 "F:\Дипломака\Project\Diplom\DiplomaWork\Pages\UserForms\Registration.razor"
                                                                                         _validation.ConfirmPassword

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(164, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _validation.ConfirmPassword = __value, _validation.ConfirmPassword))));
                __builder2.AddAttribute(165, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _validation.ConfirmPassword));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(166, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(167, "\r\n                        ");
                __Blazor.DiplomaWork.Pages.UserForms.Registration.TypeInference.CreateValidationMessage_5(__builder2, 168, 169, 
#nullable restore
#line 84 "F:\Дипломака\Project\Diplom\DiplomaWork\Pages\UserForms\Registration.razor"
                                                  () => @_validation.ConfirmPassword

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(170, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(171, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(172, "\r\n                ");
                __builder2.AddMarkupContent(173, @"<div class=""row justify-content-center mx-auto"">
                    <div class=""col-6 mt-2 mb-3 text-center"">
                        <button class=""btn btn-primary btn-lg btn-block"" type=""submit"">Sign Up</button>
                    </div>
                </div>
                ");
                __builder2.AddMarkupContent(174, "<div class=\"row text-center\">\r\n                    <div class=\"col-12 mb-2\">\r\n                        Have an account? <a href=\"login\">Log In</a>\r\n                    </div>\r\n                </div>\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(175, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(176, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(177, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 102 "F:\Дипломака\Project\Diplom\DiplomaWork\Pages\UserForms\Registration.razor"
       
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
namespace __Blazor.DiplomaWork.Pages.UserForms.Registration
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
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
