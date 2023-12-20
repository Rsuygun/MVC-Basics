using Microsoft.AspNetCore.Mvc;
using Repositories;
using Services.Contracts;

namespace StoreApp.Components
{
    public class ProductSummary : ViewComponent
    {
        // Örnek olarak 100 ürünümüz var fakat 20 tanesi satışta değil.
        // Fakat biz bu fonksiyonu kullaranak 100 ürününde görüntülemesini yaparız.
        // Bu durum bize problemler yaratır.
        private readonly IServiceManager _manager;

        public ProductSummary(IServiceManager manager)
        {
            _manager = manager;
        }

        public string Invoke()
        {
            return _manager.ProductService.GetAllProducts(false).Count().ToString(); 
        }
        //Bu yapının kullanılması daha sağlıklı olacaktır.
    }
}