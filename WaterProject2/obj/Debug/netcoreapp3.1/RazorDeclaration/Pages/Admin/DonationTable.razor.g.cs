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
    public partial class DonationTable : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "/Users/hannahsouthwick/Documents/GitHub/WaterProject2/WaterProject2/Pages/Admin/DonationTable.razor"
       

    [Parameter]
    public string TableTitle { get; set; } = "Donations";

    [Parameter]
    public IEnumerable<Donation> Donations { get; set; }

    [Parameter]
    public string ButtonLabel { get; set; } = "Collected";

    [Parameter]
    public EventCallback<int> DonationSelected { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591