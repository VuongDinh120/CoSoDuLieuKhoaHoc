#pragma checksum "C:\Users\Admin\Desktop\PCNTT-20200922T112554Z-001\PCNTT\CoSoDuLieuKhoaHoc\CoSoDuLieuKhoaHoc\Pages\PageSachVaGiaoTrinh\Sachvagiaotrinh.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61a7a0c5cef456094ea21402346b062311f8429a"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace CoSoDuLieuKhoaHoc.Pages.PageSachVaGiaoTrinh
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Admin\Desktop\PCNTT-20200922T112554Z-001\PCNTT\CoSoDuLieuKhoaHoc\CoSoDuLieuKhoaHoc\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Desktop\PCNTT-20200922T112554Z-001\PCNTT\CoSoDuLieuKhoaHoc\CoSoDuLieuKhoaHoc\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Desktop\PCNTT-20200922T112554Z-001\PCNTT\CoSoDuLieuKhoaHoc\CoSoDuLieuKhoaHoc\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\Desktop\PCNTT-20200922T112554Z-001\PCNTT\CoSoDuLieuKhoaHoc\CoSoDuLieuKhoaHoc\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\Desktop\PCNTT-20200922T112554Z-001\PCNTT\CoSoDuLieuKhoaHoc\CoSoDuLieuKhoaHoc\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Admin\Desktop\PCNTT-20200922T112554Z-001\PCNTT\CoSoDuLieuKhoaHoc\CoSoDuLieuKhoaHoc\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Admin\Desktop\PCNTT-20200922T112554Z-001\PCNTT\CoSoDuLieuKhoaHoc\CoSoDuLieuKhoaHoc\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Admin\Desktop\PCNTT-20200922T112554Z-001\PCNTT\CoSoDuLieuKhoaHoc\CoSoDuLieuKhoaHoc\_Imports.razor"
using CoSoDuLieuKhoaHoc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Admin\Desktop\PCNTT-20200922T112554Z-001\PCNTT\CoSoDuLieuKhoaHoc\CoSoDuLieuKhoaHoc\_Imports.razor"
using CoSoDuLieuKhoaHoc.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Admin\Desktop\PCNTT-20200922T112554Z-001\PCNTT\CoSoDuLieuKhoaHoc\CoSoDuLieuKhoaHoc\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Admin\Desktop\PCNTT-20200922T112554Z-001\PCNTT\CoSoDuLieuKhoaHoc\CoSoDuLieuKhoaHoc\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Admin\Desktop\PCNTT-20200922T112554Z-001\PCNTT\CoSoDuLieuKhoaHoc\CoSoDuLieuKhoaHoc\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Admin\Desktop\PCNTT-20200922T112554Z-001\PCNTT\CoSoDuLieuKhoaHoc\CoSoDuLieuKhoaHoc\_Imports.razor"
using BlazorStyled;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\Desktop\PCNTT-20200922T112554Z-001\PCNTT\CoSoDuLieuKhoaHoc\CoSoDuLieuKhoaHoc\Pages\PageSachVaGiaoTrinh\Sachvagiaotrinh.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Admin\Desktop\PCNTT-20200922T112554Z-001\PCNTT\CoSoDuLieuKhoaHoc\CoSoDuLieuKhoaHoc\Pages\PageSachVaGiaoTrinh\Sachvagiaotrinh.razor"
using Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/sachvagiaotrinh")]
    public partial class Sachvagiaotrinh : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 87 "C:\Users\Admin\Desktop\PCNTT-20200922T112554Z-001\PCNTT\CoSoDuLieuKhoaHoc\CoSoDuLieuKhoaHoc\Pages\PageSachVaGiaoTrinh\Sachvagiaotrinh.razor"
      
    int ID = 123;

    Dictionary<DateTime, string> events = new Dictionary<DateTime, string>();

    protected override void OnInitialized()
    {
        dialogService.OnOpen += Open;
        dialogService.OnClose += Close;
    }
   
    void Open(string title, Type type, Dictionary<string, object> parameters, DialogOptions options)
    {
        events.Add(DateTime.Now, "Dialog opened");
        StateHasChanged();
    }

    void Close(dynamic result)
    {
        events.Add(DateTime.Now, "Dialog closed. Result: " + result);
        StateHasChanged();
    }

    async Task ShowSimpleDialog() => await dialogService.OpenAsync("Simple Dialog", ds =>
    

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.AddMarkupContent(0, @"<RadzenCard Style=""padding: 20px;"">
        <p Style=""margin-bottom: 10px;"">Confirm?</p>
        <div class=""row"">
            <div class=""col-md-12"">
                <RadzenButton Text=""Ok"" Click=""()=> ds.Close(true)"" Style=""margin-bottom: 10px; width: 150px""></RadzenButton>
                <RadzenButton Text=""Cancel"" Click=""()=> ds.Close(false)"" ButtonStyle=""ButtonStyle.Secondary"" Style=""margin-bottom: 10px; width: 150px""></RadzenButton>
            </div>
        </div>
    </RadzenCard>");
        }
#nullable restore
#line 119 "C:\Users\Admin\Desktop\PCNTT-20200922T112554Z-001\PCNTT\CoSoDuLieuKhoaHoc\CoSoDuLieuKhoaHoc\Pages\PageSachVaGiaoTrinh\Sachvagiaotrinh.razor"
                 );
    public int sluong = 142;
    string tennsb = "NXB Đại Học Sư Phạm, 2020";
    string theloai = "Sách tham khảo";
    string linhvuc = "Khoa Học Tự Nhiên";
    string dstacgia = "Lê Văn Thăng, Trần Anh Tuấn, Đường Văn Hiếu, Hoàng Công Tín";
    string tensach = "Chiến lược và Chính sách Môi trường";
    string masach = "DTQG NVQG-2019/ĐT.06";
    string ISBN = "978-604-974-612-3";
    DateTime namxuatban = DateTime.Now;
    string filedinhkem = "IMG-6614.JPG";
    public class Order
    {
        public int CardId { get; set; }
        public string CardNr { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string CardHolder { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public int Country { get; set; }
        public int StoreId { get; set; }
        public string Warehouse { get; set; }
        public string Region { get; set; }
        public string System { get; set; }
        public int TransId { get; set; }
        public string Register { get; set; }
        public string Clerk { get; set; }
        public decimal Amount { get; set; }
        public decimal Tax { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ShipDate { get; set; }


    }

    public class CreditCard
    {
        public int CardId { get; set; }
        public string CardNr { get; set; }
    }

    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    Order order = new Order()
    {
        ExpiryDate = DateTime.Parse("10/10/2022"),
        OrderDate = DateTime.Now,
        ShipDate = DateTime.Now
    };

    List<CreditCard> cards = new List<CreditCard>
    ()
    {
        new CreditCard() { CardId = 1, CardNr = "5555555555554444" },
        new CreditCard() { CardId = 2, CardNr = "33335464564564563" },
        new CreditCard() { CardId = 3, CardNr = "34534645645645645" },
        new CreditCard() { CardId = 4, CardNr = "3453464565" },
        new CreditCard() { CardId = 5, CardNr = "879879789789" },
        new CreditCard() { CardId = 6, CardNr = "6786554634545" },
        new CreditCard() { CardId = 7, CardNr = "5687687687978987" },
        new CreditCard() { CardId = 8, CardNr = "5675687808945423" }
                                                    };
    List<CreditCard>
    card1 = new List<CreditCard>
    ()
    {
                new CreditCard() { CardId = 1, CardNr = "aaaa" },
                new CreditCard() { CardId = 2, CardNr = "33335464564564563" },
                new CreditCard() { CardId = 3, CardNr = "34534645645645645" },
                new CreditCard() { CardId = 4, CardNr = "3453464565" },
                new CreditCard() { CardId = 5, CardNr = "879879789789" },
                new CreditCard() { CardId = 6, CardNr = "6786554634545" },
                new CreditCard() { CardId = 7, CardNr = "5687687687978987" },
                new CreditCard() { CardId = 8, CardNr = "5675687808945423" }
                                                        };

    List<Country>
    countries = new List<Country>
    ()
    {
                        new Country() { Id = 1, Name = "USA" },
                        new Country() { Id = 2, Name = "Germany" }
                                                        };
    public class Test
    {
        public int id { get; set; }
        public int ithamso1 { get; set; }
        public int ithamso2 { get; set; }
        public string sthamso1 { get; set; }
        public string sthamso2 { get; set; }
        public string sthamso3 { get; set; }
        public string sthamso4 { get; set; }
        public string sthamso5 { get; set; }
        public string sthamso6 { get; set; }
        public float fthamso2 { get; set; }
        public DateTime dtthamso1 { get; set; }
        public string img { get; set; }
    }
    public List<Test>
    tests = new List<Test>
    ()
    {
                                new Test() { id = 1, ithamso1 = 12,ithamso2=232 ,sthamso1="Khoa học trái đất và khoa học môi trường liên quan khác" ,sthamso2="Cộng tác viên ngoài Đại học Huế" ,sthamso3="Khoa Lâm nghiệp" ,
                                sthamso4="Trần Anh Tuấn (Chủ nhiệm), Nguyễn Bắc Giang, Lê Thị Tịnh Chi",sthamso5="trang chiếu" ,sthamso6="aaaa",fthamso2= 55,dtthamso1=DateTime.Parse("10/10/2022"), img= "images/0.jpg"},

                                new Test() { id = 2, ithamso1 = 12,ithamso2=232 ,sthamso1="Khoa học trái đất và khoa học môi trường liên quan khác" ,sthamso2="Cộng tác viên ngoài Đại học Huế" ,sthamso3="Khoa Lâm nghiệp" ,
                                sthamso4="Trần Anh Tuấn (Chủ nhiệm), Nguyễn Bắc Giang, Lê Thị Tịnh Chi",sthamso5="trang chiếu" ,sthamso6="aaaa",fthamso2= 55,dtthamso1=DateTime.Parse("10/10/2022"), img= "images/0.jpg"},

                                new Test() { id = 3, ithamso1 = 12,ithamso2=232 ,sthamso1="Khoa học trái đất và khoa học môi trường liên quan khác" ,sthamso2="Cộng tác viên ngoài Đại học Huế" ,sthamso3="Khoa Lâm nghiệp" ,
                                sthamso4="Trần Anh Tuấn (Chủ nhiệm), Nguyễn Bắc Giang, Lê Thị Tịnh Chi",sthamso5="trang chiếu" ,sthamso6="aaaa",fthamso2= 55,dtthamso1=DateTime.Parse("10/10/2022"), img= "images/0.jpg"},
                                new Test() { id = 4,  ithamso1 = 12,ithamso2=232 ,sthamso1="Khoa học trái đất và khoa học môi trường liên quan khác" ,sthamso2="Cộng tác viên ngoài Đại học Huế" ,sthamso3="Khoa Lâm nghiệp" ,
                                sthamso4="Trần Anh Tuấn (Chủ nhiệm), Nguyễn Bắc Giang, Lê Thị Tịnh Chi",sthamso5="trang chiếu" ,sthamso6="aaaa",fthamso2= 55,dtthamso1=DateTime.Parse("10/10/2022"), img= "images/0.jpg"},

                                new Test() { id = 5,  ithamso1 = 12,ithamso2=232 ,sthamso1="Khoa học trái đất và khoa học môi trường liên quan khác" ,sthamso2="Cộng tác viên ngoài Đại học Huế" ,sthamso3="Khoa Lâm nghiệp" ,
                                sthamso4="Trần Anh Tuấn (Chủ nhiệm), Nguyễn Bắc Giang, Lê Thị Tịnh Chi",sthamso5="trang chiếu" ,sthamso6="aaaa",fthamso2= 55,dtthamso1=DateTime.Parse("10/10/2022"), img= "images/0.jpg"},

                                new Test() { id = 6, ithamso1 = 12,ithamso2=232 ,sthamso1="Khoa học trái đất và khoa học môi trường liên quan khác" ,sthamso2="Cộng tác viên ngoài Đại học Huế" ,sthamso3="Khoa Lâm nghiệp" ,
                                sthamso4="Trần Anh Tuấn (Chủ nhiệm), Nguyễn Bắc Giang, Lê Thị Tịnh Chi",sthamso5="trang chiếu" ,sthamso6="aaaa",fthamso2= 55,dtthamso1=DateTime.Parse("10/10/2022"), img= "images/0.jpg"},

                                new Test() { id = 7, ithamso1 = 12,ithamso2=232 ,sthamso1="Khoa học trái đất và khoa học môi trường liên quan khác" ,sthamso2="Cộng tác viên ngoài Đại học Huế" ,sthamso3="Khoa Lâm nghiệp" ,
                                sthamso4="Trần Anh Tuấn (Chủ nhiệm), Nguyễn Bắc Giang, Lê Thị Tịnh Chi",sthamso5="trang chiếu" ,sthamso6="aaaa",fthamso2= 55,dtthamso1=DateTime.Parse("10/10/2022"), img= "images/0.jpg"},

                                new Test() { id = 8,  ithamso1 = 12,ithamso2=232 ,sthamso1="Khoa học trái đất và khoa học môi trường liên quan khác" ,sthamso2="Cộng tác viên ngoài Đại học Huế" ,sthamso3="Khoa Lâm nghiệp" ,
                                sthamso4="Trần Anh Tuấn (Chủ nhiệm), Nguyễn Bắc Giang, Lê Thị Tịnh Chi",sthamso5="trang chiếu" ,sthamso6="aaaa",fthamso2= 55,dtthamso1=DateTime.Parse("10/10/2022"), img= "images/0.jpg"},

                                new Test() { id = 9, ithamso1 =90 ,ithamso2=124 ,sthamso1="TYJTEFJ6" ,sthamso2="Nguyễn Văn i" ,sthamso3="inally be able toed battary." ,
                                sthamso4="Featured Games" ,sthamso5="phim trinh thám" ,sthamso6="kklll",fthamso2=2342 ,dtthamso1= DateTime.Parse("10/10/2022"),img= "images/avt.png"},

                                new Test() { id = 10, ithamso1 =100 ,ithamso2=264 ,sthamso1="TYJDFCTJE" ,sthamso2="Nguyễn Văn j" ,sthamso3="Youndroid app unlry." ,
                                sthamso4="okokokokoko" ,sthamso5="thế giới khoa học" ,sthamso6="xxxx",fthamso2=3633 ,dtthamso1=DateTime.Parse("10/10/2022") ,img= "images/avt.png"},
                                new Test() { id = 11, ithamso1 =100 ,ithamso2=264 ,sthamso1="fwegr" ,sthamso2="Nguyễn Văn ưe" ,sthamso3="ffe app unlry." ,
                                sthamso4="okokokokoko" ,sthamso5="thế gưefwefehọc" ,sthamso6="ẻgwef",fthamso2=3633 ,dtthamso1=DateTime.Parse("10/10/2022") ,img= "images/map.png"},
                                new Test() { id = 12, ithamso1 =343 ,ithamso2=54645 ,sthamso1="Tham số 1" ,sthamso2="Nguyễn Văn 43rg" ,sthamso3="aaaaaaaaaaaaaaaaaaaaaaaaaaa." ,
                                sthamso4="aaaaaaaaaaaaaaaaaaaaaaaaaa" ,sthamso5="thế gưefwefehọc" ,sthamso6="ẻgwef",fthamso2=3633 ,dtthamso1=DateTime.Parse("10/10/2033") ,img= "images/avt.png"}
                                                        };


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DialogService dialogService { get; set; }
    }
}
#pragma warning restore 1591
