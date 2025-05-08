using Microsoft.AspNetCore.Mvc;
using MultiShop.DtoLayer.CatalogDtos.CategoryDtos;

namespace MultiShop.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Category")]
    public class CategoryController : Controller
    {

        [Route("Index")]
        public async Task<IActionResult> Index()
        {
            CategoryViewBagList();
            return View();
        }

        [HttpGet]
        [Route("CreateCategory")]
        public IActionResult CreateCategory()
        {
            CategoryViewBagList();
            return View();
        }
        [HttpPost]
        [Route("CreateCategory")]

        public async Task<IActionResult> CreateCategory(CreateCategoryDto createCategoryDto)
        {
            //await _categoryService.CreateCategoryAsync(createCategoryDto);
            //return RedirectToAction("Index", "Category", new { area = "Admin" });
            return View();

        }

        [Route("DeleteCategory/{id}")]
        public async Task<IActionResult> DeleteCategory(string id)
        {
            //await _categoryService.DeleteCategoryAsync(id);
            //return RedirectToAction("Index", "Category", new { area = "Admin" });
            return View();

        }

        [Route("UpdateCategory/{id}")]
        [HttpGet]
        public async Task<IActionResult> UpdateCategory(string id)
        {
            //CategoryViewBagList();
            //var values = await _categoryService.GetByIDCategoryAsync(id);
            return View();
        }
        [Route("UpdateCategory/{id}")]
        [HttpPost]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryDto updateCategoryDto)
        {
            //await _categoryService.UpdateCategoryAsync(updateCategoryDto);
            //return RedirectToAction("Index", "Category", new { area = "Admin" });
            return View();
        }


        void CategoryViewBagList()
        {
            ViewBag.v1 = "Anasayfa";
            ViewBag.v2 = "Kategoriler";
            ViewBag.v3 = "Kategori Listesi";
            ViewBag.v0 = "Kategori İşlemleri";
        }
    }
}
