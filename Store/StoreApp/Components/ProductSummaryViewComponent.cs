using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace StoreApp.Components
{
    public class ProductSummaryViewComponent : ViewComponent
    {
        // Örnek olarak 100 ürünümüz var fakat 20 tanesi satışta değil.
        // Fakat biz bu fonksiyonu kullaranak 100 ürününde görüntülemesini yaparız.
        // Bu durum bize problemler yaratır.
        //Bu yapının kullanılması daha sağlıklı olacaktır.
        private readonly IServiceManager _manager;

        public ProductSummaryViewComponent(IServiceManager manager)
        {
            _manager = manager;
        }

        public string Invoke()
        {
            return _manager.ProductService.GetAllProducts(false).Count().ToString(); 
        }
    }
}