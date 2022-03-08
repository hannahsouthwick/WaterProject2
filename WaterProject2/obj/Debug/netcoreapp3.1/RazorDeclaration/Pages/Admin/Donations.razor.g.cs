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
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/donations")]
    public partial class Donations : OwningComponentBase<IDonationRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "/Users/hannahsouthwick/Documents/GitHub/WaterProject2/WaterProject2/Pages/Admin/Donations.razor"
       
    public IDonationRepository repo => Service;

    public IEnumerable<Donation> AllDonations { get; set; }
    public IEnumerable<Donation> UncollectedDonations { get; set; }
    public IEnumerable<Donation> CollectedDonations { get; set; }

    protected async override Task OnInitializedAsync()
    {
        await UpdateData();
    }

    public async Task UpdateData()
    {
        AllDonations = await repo.Donations.ToListAsync();
        UncollectedDonations = AllDonations.Where(x => !x.DonationReceived);
        CollectedDonations = AllDonations.Where(x => x.DonationReceived);
    }

    public void CollectDonation(int id) => UpdateDonation(id, true);
    public void ResetDonation(int id) => UpdateDonation(id, false);

    private void UpdateDonation (int id, bool donated)
    {
        Donation d = repo.Donations.FirstOrDefault(x => x.DonationId == id);
        d.DonationReceived = donated;

        repo.SaveDonation(d);
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
