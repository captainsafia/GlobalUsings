#pragma checksum "/Users/captainsafia/Verifications/GlobalUsings/Pages/Counter.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6c4898e319339142241c91e966501131c934fe172fa0b38489d0cd330ea13274"
// <auto-generated/>
#pragma warning disable 1591
namespace GlobalUsings.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Counter</h1>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddAttribute(2, "role", "status");
            __builder.AddContent(3, "Current count: ");
#nullable restore
#line (5,34)-(5,46) 24 "/Users/captainsafia/Verifications/GlobalUsings/Pages/Counter.razor"
__builder.AddContent(4, currentCount);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.AddMarkupContent(6, "<button class=\"btn btn-primary\" @onclick=\"IncrementCount\">Click me</button>");
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "/Users/captainsafia/Verifications/GlobalUsings/Pages/Counter.razor"
       
    private int currentCount = 0;
    List<int> numbers = new List<int>() { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };


    private void IncrementCount()
    {
        currentCount++;
        var studentNames = numbers.Where(p => p > 3);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
