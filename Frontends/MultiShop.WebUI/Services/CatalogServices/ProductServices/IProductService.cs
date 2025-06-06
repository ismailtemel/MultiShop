﻿using MultiShop.DtoLayer.CatalogDtos.ProductDtos;

namespace MultiShop.WebUI.Services.CatalogServices.ProductServices
{
    public interface IProductService
    {
        Task<List<ResultProductDto>> GetAllProductAsync();
        Task CreateProductAsync(CreateProductDto createProductDto);
        Task UpdateProductAsync(UpdateProductDto updateProductDto);
        Task DeleteProductAsync(string id);
        Task<UpdateProductDto> GetByIDProductAsync(string id);
        Task<List<ResultProductWithCategoryDto>> GetProductsWithCategroyAsync();
        Task<List<ResultProductWithCategoryDto>> GetProductsWithCategroyByCategoryIDAsync(string categoryID);
    }
}
