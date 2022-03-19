using EFCoreBase.Application.Dto;
using EFCoreBase.Application.Dto.Product;

namespace EFCoreBase.Application.Interfaces.Service
{
    public interface IProductService
    {
        public Task<Response<List<ProductDto>>> GetProductsAsync();
        public Task<Response<ProductDto>> GetByIdAsync(string id);
        public Task<Response<List<ProductDto>>> GetAllByUserIdAsync(string userId);
        public Task<Response<ProductDto>> CreateAsync(ProductCreateDto productCreateDto);
        public Task<Response<NoContent>> UpdateAsync(ProductUpdateDto productUpdateDto);
        public Task<Response<NoContent>> DeleteAsync(string id);
    }
}
