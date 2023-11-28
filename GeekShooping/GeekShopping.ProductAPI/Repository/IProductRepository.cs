using GeekShopping.ProductAPI.Data.Dto.Request;
using GeekShopping.ProductAPI.Data.Dto.Response;

namespace GeekShopping.ProductAPI.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductResponse>> FindAll();
        Task<ProductResponse> FindById(long id);
        Task<ProductResponse> Create(ProductRequest request);
        Task<ProductResponse> Update(ProductRequest request);
        Task<bool> Delete(long id);
    }
}
