// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Sejuela_SportsStore.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\VV140\Downloads\Sejuela_SportsStore\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\VV140\Downloads\Sejuela_SportsStore\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\VV140\Downloads\Sejuela_SportsStore\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\VV140\Downloads\Sejuela_SportsStore\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\VV140\Downloads\Sejuela_SportsStore\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\VV140\Downloads\Sejuela_SportsStore\SportsStore\Pages\Admin\_Imports.razor"
using Sejuela_SportsStore.Models;

#line default
#line hidden
#nullable disable
    public partial class OrderTable : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "C:\Users\VV140\Downloads\Sejuela_SportsStore\SportsStore\Pages\Admin\OrderTable.razor"
       

    [Parameter]
    public string TableTitle { get; set; } = "Orders";

    [Parameter]
    public IEnumerable<Order> Orders { get; set; }

    [Parameter]
    public string ButtonLabel { get; set; } = "Ship";

    [Parameter]
    public EventCallback<int> OrderSelected{ get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
