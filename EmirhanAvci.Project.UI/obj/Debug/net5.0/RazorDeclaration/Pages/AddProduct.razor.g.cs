// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace EmirhanAvci.Project.UI.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 3 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\_Imports.razor"
using EmirhanAvci.Project.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\_Imports.razor"
using EmirhanAvci.Project.UI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\_Imports.razor"
using EmirhanAvci.Project.EntityLayer.Dtos.ProductDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\_Imports.razor"
using EmirhanAvci.Project.EntityLayer.Dtos.BrandDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\_Imports.razor"
using EmirhanAvci.Project.EntityLayer.Dtos.ColorDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\_Imports.razor"
using EmirhanAvci.Project.EntityLayer.Dtos.OrderDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\_Imports.razor"
using EmirhanAvci.Project.EntityLayer.Dtos.OfferDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\_Imports.razor"
using EmirhanAvci.Project.EntityLayer.Dtos.CategoryDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\_Imports.razor"
using EmirhanAvci.Project.SharedLayer.Utilities.Results.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\Pages\AddProduct.razor"
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddProduct")]
    public partial class AddProduct : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 73 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\Pages\AddProduct.razor"
       
    public ProductAddDto Product = new();

    public DataResult<CategoryListDto> Categories;

    public DataResult<BrandListDto> Brands;

    public DataResult<ColorListDto> Colors;


    protected override async Task OnInitializedAsync()
    {
        var client = ClientFactory.CreateClient();

        var url = $"http://localhost:5001/api/Brand/GetAll";
        var request = new HttpRequestMessage(HttpMethod.Get, url);

        var token = await Storage.GetAsync<string>("token");


        request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Value);

        var response = await client.SendAsync(request);

        //WithAuthorizationMod
        if (response.IsSuccessStatusCode)
        {
            var json = await response.Content.ReadAsStringAsync();
            Brands= System.Text.Json.JsonSerializer.Deserialize<DataResult<BrandListDto>>(json);
            Categories = await client.GetFromJsonAsync<DataResult<CategoryListDto>>("http://localhost:5001/api/Category/GetAll");
            Colors = await client.GetFromJsonAsync<DataResult<ColorListDto>>("http://localhost:5001/api/Color/GetAll");

        }
        //NotAuthorizationMod
        Categories = await client.GetFromJsonAsync<DataResult<CategoryListDto>>("http://localhost:5001/api/Category/GetAll");
        Brands = await client.GetFromJsonAsync<DataResult<BrandListDto>>("http://localhost:5001/api/Brand/GetAll");
        Colors = await client.GetFromJsonAsync<DataResult<ColorListDto>>("http://localhost:5001/api/Color/GetAll");
    }

    private async Task Submit()
    {

        var client = ClientFactory.CreateClient();

        var response = await client.PostAsJsonAsync("http://localhost:5001/api/Product/AddAsync", Product);
        NavManager.NavigateTo("/product");


    }
    void HandleFileSelection(InputFileChangeEventArgs eventArgs)
    {
        IReadOnlyList<IBrowserFile> selectedFiles;
        const int MaxAllowedFiles = 1;
        selectedFiles = eventArgs.GetMultipleFiles(MaxAllowedFiles);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProtectedLocalStorage Storage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpClientFactory ClientFactory { get; set; }
    }
}
#pragma warning restore 1591
