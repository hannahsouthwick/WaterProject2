#pragma checksum "/Users/hannahsouthwick/Documents/GitHub/WaterProject2/WaterProject2/Pages/Admin/Donations.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6cc2dfa79bc05abee188402aecdb3a019f71ef76"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/donations")]
    public partial class Donations : OwningComponentBase<IDonationRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<WaterProject2.Pages.Admin.DonationTable>(0);
            __builder.AddAttribute(1, "TableTitle", "Uncollected Donations");
            __builder.AddAttribute(2, "Donations", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<WaterProject2.Models.Donation>>(
#nullable restore
#line 5 "/Users/hannahsouthwick/Documents/GitHub/WaterProject2/WaterProject2/Pages/Admin/Donations.razor"
                                                             UncollectedDonations

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ButtonLabel", "Collected");
            __builder.AddAttribute(4, "DonationSelected", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 6 "/Users/hannahsouthwick/Documents/GitHub/WaterProject2/WaterProject2/Pages/Admin/Donations.razor"
                                                         CollectDonation

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\n\n");
            __builder.OpenComponent<WaterProject2.Pages.Admin.DonationTable>(6);
            __builder.AddAttribute(7, "TableTitle", "Collected Donations");
            __builder.AddAttribute(8, "Donations", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<WaterProject2.Models.Donation>>(
#nullable restore
#line 9 "/Users/hannahsouthwick/Documents/GitHub/WaterProject2/WaterProject2/Pages/Admin/Donations.razor"
                                                           CollectedDonations

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "ButtonLabel", "Reset");
            __builder.AddAttribute(10, "DonationSelected", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 10 "/Users/hannahsouthwick/Documents/GitHub/WaterProject2/WaterProject2/Pages/Admin/Donations.razor"
                                                     ResetDonation

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\n\n");
            __builder.OpenElement(12, "button");
            __builder.AddAttribute(13, "class", "btn btn-info");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "/Users/hannahsouthwick/Documents/GitHub/WaterProject2/WaterProject2/Pages/Admin/Donations.razor"
                                         x=> UpdateData()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(15, "Refresh Data");
            __builder.CloseElement();
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
