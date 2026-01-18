using PAC.Back_end.Application.DTOs;

namespace PAC.Back_end.Application.Interfaces.Services;

public interface IProductService
{
    Task<IEnumerable<ProductDTO>> GetAllProductsAsync();
    Task<ProductDTO?> GetProductByIdAsync(int id);
    Task<ProductDTO?> AddProductAsync(CreateProductDTO productDto);
    Task UpdateProductAsync(UpdateProductDTO productDto);
    Task DeleteProductAsync(int id);
}
