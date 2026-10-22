using StoreBackend.Dto;

namespace StoreBackend.DomainService;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public Task<List<Product>> GetAllAsync()
    {
        return _productRepository.GetAllAsync();
    }

    public Task<Product?> GetByIdAsync(Guid productId)
    {
        return _productRepository.GetByIdAsync(productId);
    }

    public Task<Product> AddAsync(ProductDto product)
    {
        var productEntity = new Product
        {
            ProductResourceId = product.ProductResourceId,
            Name = product.Name
        };

        return _productRepository.AddAsync(productEntity);
    }

    public Task DeleteAsync(Guid productId)
    {
        throw new NotImplementedException();
    }
}