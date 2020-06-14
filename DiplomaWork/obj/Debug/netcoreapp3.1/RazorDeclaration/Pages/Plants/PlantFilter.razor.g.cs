#pragma checksum "F:\Дипломака\Project\Diplom\DiplomaWork\Pages\Plants\PlantFilter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4514a6cf7a371ce5fc2c3d1834a59dc6c4bac057"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace DiplomaWork.Pages.Plants
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/plants/search")]
    public partial class PlantFilter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "F:\Дипломака\Project\Diplom\DiplomaWork\Pages\Plants\PlantFilter.razor"
       
    private List<Plant> plants;
    string title = "";
    DateTime? waterdate;
    DateTime? fertdate;
    protected override void OnInitialized()
    {
        plants = Repository.GetPlants();
    }

    private void SearchForPlants()
    {
        plants = plants.Where(x => x.Title.Contains(title)).ToList();
        Console.WriteLine(title);
        Console.WriteLine(waterdate);
        Console.WriteLine(fertdate);
    }

    private void Clear()
    {
        plants = Repository.GetPlants();
        title = "";
        waterdate = null;
        fertdate = null;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepository Repository { get; set; }
    }
}
#pragma warning restore 1591
