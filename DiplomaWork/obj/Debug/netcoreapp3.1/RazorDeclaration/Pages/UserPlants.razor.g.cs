#pragma checksum "F:\Дипломака\Project\Diplom\DiplomaWork\Pages\UserPlants.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59c58066de10a976e93989d8605ab1da8344b832"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace DiplomaWork.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/plants")]
    public partial class UserPlants : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "F:\Дипломака\Project\Diplom\DiplomaWork\Pages\UserPlants.razor"
       
    private List<Plant> plants;

    protected async override Task OnInitializedAsync()
    {
        plants = repository.GetPlants();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepository repository { get; set; }
    }
}
#pragma warning restore 1591
