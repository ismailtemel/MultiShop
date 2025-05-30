using Microsoft.AspNetCore.Mvc;
using MultiShop.WebUI.Services.CatalogServices.ProductDetailServices;

namespace MultiShop.WebUI.ViewComponents.ProductDetailsViewComponent
{
    public class _ProductDetailInformationComponentPartial : ViewComponent
    {
        private readonly IProductDetailService _productDetailService;

        public _ProductDetailInformationComponentPartial(IProductDetailService productDetailService)
        {
            _productDetailService = productDetailService;
        }

        public async Task<IViewComponentResult> InvokeAsync(string id)
        {
            var values = await _productDetailService.GetByProductIDProductDetailAsync(id);
            return View(values);
        }
    }
}
