// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WaterProject2.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "/Users/hannahsouthwick/Documents/GitHub/WaterProject2/WaterProject2/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/hannahsouthwick/Documents/GitHub/WaterProject2/WaterProject2/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/hannahsouthwick/Documents/GitHub/WaterProject2/WaterProject2/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/hannahsouthwick/Documents/GitHub/WaterProject2/WaterProject2/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/hannahsouthwick/Documents/GitHub/WaterProject2/WaterProject2/Pages/Admin/_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/hannahsouthwick/Documents/GitHub/WaterProject2/WaterProject2/Pages/Admin/_Imports.razor"
using WaterProject2.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/projects/edit/{id:long}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/projects/create")]
    public partial class Editor : OwningComponentBase<IWaterProjectRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 64 "/Users/hannahsouthwick/Documents/GitHub/WaterProject2/WaterProject2/Pages/Admin/Editor.razor"
       

    [Parameter]
    public long Id { get; set; } = 0;

    public string ThemeColor => Id == 0 ? "primary" : "warning";
    public string TitleText => Id == 0 ? "Create" : "Edit";

    public Project p { get; set; } = new Project();

    public IWaterProjectRepository repo => Service;

    protected override void OnParametersSet()
    {
        if (Id !=0) //Existing
        {
            p = repo.Projects.FirstOrDefault(x => x.ProjectId == Id);
        }
    }

    public void SaveProject()
    {
        if (Id == 0) //New
        {
            repo.CreateProject(p);
        }
        else
        {
            repo.SaveProject(p);
        }
    }

    [Inject]
    public NavigationManager NavManager { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
