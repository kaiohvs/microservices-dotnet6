using AutoMapper;
using GeekShopping.ProductAPI.Data.Dto.Request;
using GeekShopping.ProductAPI.Data.Dto.Response;
using GeekShopping.ProductAPI.Model;
using GeekShopping.ProductAPI.Model.Context;
using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly SqlContext _context;
        private readonly IMapper _mapper;

        public ProductRepository(SqlContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<IEnumerable<ProductResponse>> FindAll()
        {
            IEnumerable<Product> products = await _context.products.ToListAsync();

            return _mapper.Map<IEnumerable<ProductResponse>>(products);
        }

        public async Task<ProductResponse> FindById(long id)
        {
            var productId = await _context.products.Where(x => x.Id == id).FirstOrDefaultAsync();

            return _mapper.Map<ProductResponse>(productId);
        }

        public async Task<ProductResponse> Create(ProductRequest request)
        {
            var product = _mapper.Map<Product>(request);
            await _context.products.AddAsync(product);
            await _context.SaveChangesAsync();

            return _mapper.Map<ProductResponse>(product);
        }
        public async Task<ProductResponse> Update(ProductRequest request)
        {
            var product = _mapper.Map<Product>(request);
            _context.products.Update(product);
            await _context.SaveChangesAsync();

            return _mapper.Map<ProductResponse>(product);

        }
        public async Task<bool> Delete(long id)
        {
            try
            {
                var productId = await _context.products.Where(x => x.Id == id).FirstOrDefaultAsync();

                if (productId != null)
                {
                    _context.products.Remove(productId);
                    await _context.SaveChangesAsync();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
