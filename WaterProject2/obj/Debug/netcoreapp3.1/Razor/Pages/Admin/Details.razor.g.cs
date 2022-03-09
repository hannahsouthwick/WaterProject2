#pragma checksum "/Users/hannahsouthwick/Documents/GitHub/WaterProject2/WaterProject2/Pages/Admin/Details.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6693856abfe0101ebf1b46bbabf4586483e93a17"
// <auto-generated/>
#pragma warning disable 1591
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/projects/details/{id:long}")]
    public partial class Details : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"bg-info text-white text-center p-1\">Details</h3>\n\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table table-sm table-bordered table-striped");
            __builder.AddMarkupContent(3, "\n    ");
            __builder.OpenElement(4, "tbody");
            __builder.AddMarkupContent(5, "\n        ");
            __builder.OpenElement(6, "tr");
            __builder.AddMarkupContent(7, "<th>Project ID:</th>");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 7 "/Users/hannahsouthwick/Documents/GitHub/WaterProject2/WaterProject2/Pages/Admin/Details.razor"
                                     p.ProjectId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\n        ");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "<th>Name:</th>");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 8 "/Users/hannahsouthwick/Documents/GitHub/WaterProject2/WaterProject2/Pages/Admin/Details.razor"
                               p.ProjectName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n        ");
            __builder.OpenElement(16, "tr");
            __builder.AddMarkupContent(17, "<th>Type:</th>");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 9 "/Users/hannahsouthwick/Documents/GitHub/WaterProject2/WaterProject2/Pages/Admin/Details.razor"
                               p.ProjectType

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n        ");
            __builder.OpenElement(21, "tr");
            __builder.AddMarkupContent(22, "<th>Regional Program:</th>");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 10 "/Users/hannahsouthwick/Documents/GitHub/WaterProject2/WaterProject2/Pages/Admin/Details.razor"
                                           p.ProjectRegionalProgram

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\n        ");
            __builder.OpenElement(26, "tr");
            __builder.AddMarkupContent(27, "<th>Impact:</th>");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 11 "/Users/hannahsouthwick/Documents/GitHub/WaterProject2/WaterProject2/Pages/Admin/Details.razor"
                                 p.ProjectImpact

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n        ");
            __builder.OpenElement(31, "tr");
            __builder.AddMarkupContent(32, "<th>Phase:</th>");
            __builder.OpenElement(33, "td");
            __builder.AddContent(34, 
#nullable restore
#line 12 "/Users/hannahsouthwick/Documents/GitHub/WaterProject2/WaterProject2/Pages/Admin/Details.razor"
                                p.ProjectPhase

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\n        ");
            __builder.OpenElement(36, "tr");
            __builder.AddMarkupContent(37, "<th>Functionality Status:</th>");
            __builder.OpenElement(38, "td");
            __builder.AddContent(39, 
#nullable restore
#line 13 "/Users/hannahsouthwick/Documents/GitHub/WaterProject2/WaterProject2/Pages/Admin/Details.razor"
                                               p.ProjectFunctionalityStatus

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\n\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(43);
            __builder.AddAttribute(44, "class", "btn btn-warning");
            __builder.AddAttribute(45, "href", 
#nullable restore
#line 17 "/Users/hannahsouthwick/Documents/GitHub/WaterProject2/WaterProject2/Pages/Admin/Details.razor"
                                        EditUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(46, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(47, "Edit");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(48, "\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(49);
            __builder.AddAttribute(50, "class", "btn btn-secondary");
            __builder.AddAttribute(51, "href", "/admin/projects");
            __builder.AddAttribute(52, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(53, "Back");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "/Users/hannahsouthwick/Documents/GitHub/WaterProject2/WaterProject2/Pages/Admin/Details.razor"
       

    [Inject]
    public IWaterProjectRepository repo { get; set; }

    [Parameter]
    public long Id { get; set; }

    public Project p { get; set; }

    protected override void OnParametersSet()
    {
        p = repo.Projects.FirstOrDefault(x => x.ProjectId == Id);
    }

    public string EditUrl => $"/admin/projects/edit/{p.ProjectId}";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591