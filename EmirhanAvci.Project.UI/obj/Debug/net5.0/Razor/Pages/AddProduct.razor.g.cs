#pragma checksum "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\Pages\AddProduct.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11582a33c81b68382c2fd13caf83692d6f1c9d5d"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h3>Add Product</h3>\r\n<hr>\r\n<br>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 9 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\Pages\AddProduct.razor"
                  Product

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 9 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\Pages\AddProduct.razor"
                                           Submit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "form-group");
                __builder2.AddMarkupContent(9, "<label for=\"Name\">Name: </label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(10);
                __builder2.AddAttribute(11, "class", "form-control");
                __builder2.AddAttribute(12, "id", "Name");
                __builder2.AddAttribute(13, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\Pages\AddProduct.razor"
                                                               Product.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Product.Name = __value, Product.Name))));
                __builder2.AddAttribute(15, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Product.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n        ");
                __Blazor.EmirhanAvci.Project.UI.Pages.AddProduct.TypeInference.CreateValidationMessage_0(__builder2, 17, 18, 
#nullable restore
#line 14 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\Pages\AddProduct.razor"
                                () => Product.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n    ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "form-group");
                __builder2.AddMarkupContent(22, "<label for=\"Description\">Description: </label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(23);
                __builder2.AddAttribute(24, "class", "form-control");
                __builder2.AddAttribute(25, "id", "Description");
                __builder2.AddAttribute(26, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\Pages\AddProduct.razor"
                                                                      Product.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Product.Description = __value, Product.Description))));
                __builder2.AddAttribute(28, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Product.Description));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r\n        ");
                __Blazor.EmirhanAvci.Project.UI.Pages.AddProduct.TypeInference.CreateValidationMessage_1(__builder2, 30, 31, 
#nullable restore
#line 19 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\Pages\AddProduct.razor"
                                () => Product.Description

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n    ");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "form-group");
                __builder2.AddMarkupContent(35, "<label for=\"Description\">Price: </label>\r\n        ");
                __Blazor.EmirhanAvci.Project.UI.Pages.AddProduct.TypeInference.CreateInputNumber_2(__builder2, 36, 37, "form-control", 38, "Price", 39, 
#nullable restore
#line 23 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\Pages\AddProduct.razor"
                                                                  Product.Price

#line default
#line hidden
#nullable disable
                , 40, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Product.Price = __value, Product.Price)), 41, () => Product.Price);
                __builder2.AddMarkupContent(42, "\r\n        ");
                __Blazor.EmirhanAvci.Project.UI.Pages.AddProduct.TypeInference.CreateValidationMessage_3(__builder2, 43, 44, 
#nullable restore
#line 24 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\Pages\AddProduct.razor"
                                () => Product.Price

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n    ");
                __builder2.OpenElement(46, "div");
                __builder2.AddAttribute(47, "class", "form-group");
                __builder2.AddMarkupContent(48, "<label for=\"BrandId\">Categories: </label><br>");
#nullable restore
#line 28 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\Pages\AddProduct.razor"
         if (Categories != null)
        {

#line default
#line hidden
#nullable disable
                __Blazor.EmirhanAvci.Project.UI.Pages.AddProduct.TypeInference.CreateInputSelect_4(__builder2, 49, 50, "form-control", 51, "categories", 52, 
#nullable restore
#line 30 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\Pages\AddProduct.razor"
                                                                           Product.CategoryId

#line default
#line hidden
#nullable disable
                , 53, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Product.CategoryId = __value, Product.CategoryId)), 54, () => Product.CategoryId, 55, (__builder3) => {
#nullable restore
#line 31 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\Pages\AddProduct.razor"
                 foreach (var category in Categories.Data.Categories)
                    {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(56, "option");
                    __builder3.AddAttribute(57, "value", 
#nullable restore
#line 33 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\Pages\AddProduct.razor"
                                    category.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(58, 
#nullable restore
#line 33 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\Pages\AddProduct.razor"
                                                  category.Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 34 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\Pages\AddProduct.razor"
                    }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.AddMarkupContent(59, "\r\n            ");
                __Blazor.EmirhanAvci.Project.UI.Pages.AddProduct.TypeInference.CreateValidationMessage_5(__builder2, 60, 61, 
#nullable restore
#line 36 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\Pages\AddProduct.razor"
                                    () => Product.CategoryId

#line default
#line hidden
#nullable disable
                );
#nullable restore
#line 37 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\Pages\AddProduct.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(62, "<small id=\"emailHelp\" class=\"form-text text-muted\">We\'ll never share your email with anyone else.</small>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n    ");
                __builder2.OpenElement(64, "div");
                __builder2.AddAttribute(65, "class", "form-group");
                __builder2.AddMarkupContent(66, "<label for=\"BrandId\">Brands: </label><br>");
#nullable restore
#line 42 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\Pages\AddProduct.razor"
         if (Brands != null && Categories != null)
        {

#line default
#line hidden
#nullable disable
                __Blazor.EmirhanAvci.Project.UI.Pages.AddProduct.TypeInference.CreateInputSelect_6(__builder2, 67, 68, "form-control", 69, "brands", 70, 
#nullable restore
#line 44 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\Pages\AddProduct.razor"
                                                                       Product.BrandId

#line default
#line hidden
#nullable disable
                , 71, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Product.BrandId = __value, Product.BrandId)), 72, () => Product.BrandId, 73, (__builder3) => {
#nullable restore
#line 45 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\Pages\AddProduct.razor"
                 foreach (var brand in Brands.Data.Brands)
                    {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(74, "option");
                    __builder3.AddAttribute(75, "value", 
#nullable restore
#line 47 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\Pages\AddProduct.razor"
                                    brand.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(76, 
#nullable restore
#line 47 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\Pages\AddProduct.razor"
                                               brand.Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 48 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\Pages\AddProduct.razor"
                    }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.AddMarkupContent(77, "\r\n            ");
                __Blazor.EmirhanAvci.Project.UI.Pages.AddProduct.TypeInference.CreateValidationMessage_7(__builder2, 78, 79, 
#nullable restore
#line 50 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\Pages\AddProduct.razor"
                                    () => Product.BrandId

#line default
#line hidden
#nullable disable
                );
#nullable restore
#line 51 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\Pages\AddProduct.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\r\n    ");
                __builder2.OpenElement(81, "div");
                __builder2.AddAttribute(82, "class", "form-group");
                __builder2.AddMarkupContent(83, "<label for=\"ColorId\">Colors: </label><br>");
#nullable restore
#line 55 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\Pages\AddProduct.razor"
         if (Colors != null && Brands != null && Categories != null)
        {

#line default
#line hidden
#nullable disable
                __Blazor.EmirhanAvci.Project.UI.Pages.AddProduct.TypeInference.CreateInputSelect_8(__builder2, 84, 85, "form-control", 86, "colors", 87, 
#nullable restore
#line 57 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\Pages\AddProduct.razor"
                                                                       Product.ColorId

#line default
#line hidden
#nullable disable
                , 88, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Product.ColorId = __value, Product.ColorId)), 89, () => Product.ColorId, 90, (__builder3) => {
#nullable restore
#line 58 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\Pages\AddProduct.razor"
                 foreach (var color in Colors.Data.Colors)
                    {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(91, "option");
                    __builder3.AddAttribute(92, "value", 
#nullable restore
#line 60 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\Pages\AddProduct.razor"
                                    color.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(93, 
#nullable restore
#line 60 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\Pages\AddProduct.razor"
                                               color.Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 61 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\Pages\AddProduct.razor"
                    }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.AddMarkupContent(94, "\r\n            ");
                __Blazor.EmirhanAvci.Project.UI.Pages.AddProduct.TypeInference.CreateValidationMessage_9(__builder2, 95, 96, 
#nullable restore
#line 63 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\Pages\AddProduct.razor"
                                    () => Product.ColorId

#line default
#line hidden
#nullable disable
                );
#nullable restore
#line 64 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\Pages\AddProduct.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(97, "<small id=\"emailHelp\" class=\"form-text text-muted\">We\'ll never share your email with anyone else.</small>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(98, "\r\n    ");
                __builder2.OpenElement(99, "div");
                __builder2.AddAttribute(100, "class", "form-group");
                __builder2.AddMarkupContent(101, "<label for=\"ImageFile\">Image: </label><br>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(102);
                __builder2.AddAttribute(103, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 69 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\Pages\AddProduct.razor"
                              HandleFileSelection

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(104, "id", "imagefile");
                __builder2.AddAttribute(105, "Value", 
#nullable restore
#line 69 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\Pages\AddProduct.razor"
                                                                               Product.ImageFile

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(106, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Product.ImageFile = __value, Product.ImageFile));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(107, "\r\n    ");
                __builder2.AddMarkupContent(108, "<button type=\"submit\" class=\"btn btn-primary\">Kaydet</button>");
            }
            ));
            __builder.CloseComponent();
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
namespace __Blazor.EmirhanAvci.Project.UI.Pages.AddProduct
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_8<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_9<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
