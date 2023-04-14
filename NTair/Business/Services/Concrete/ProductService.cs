namespace Business.Services.Concrete;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    public ProductService(IProductRepository productRepository, IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }

    public async Task<IResult> CreateAsync(ProductCreateDto productCreateDto)
    {
        
        await _productRepository.CreateAsync(_mapper.Map<Product>(productCreateDto));
      int result=  await _productRepository.SaveAsync();
        if (result is 0)
        {
            return new ErrorResult("Product is not created");
        }
        return new SuccessResult("Product is created");


    }

    public async Task<IResult> DeleteByIdAsync(int id)
    {
        Product product = await _productRepository.GetAsync(p => p.Id == id && !p.IsDeleted);
        if (product is null) throw new NotFoundException(Messages.ProductNotFound);
        _productRepository.Delete(product);
        int result = await _productRepository.SaveAsync();
        if (result is 0)
        {
            return new ErrorResult("Product is not deleted");
        }
        return new SuccessResult("Product is deleted");

    }

    public async Task<IDataResult<List<ProductGetDto>>> GetAllAsync()
    {
        List<Product> products = await _productRepository.GetAllAsync(p => !p.IsDeleted);
        if (products is null)
        {
            return new ErrorDataResult<List<ProductGetDto>>("Products are not found");
        };
        return new SuccessDataResult<List<ProductGetDto>>(_mapper.Map<List<ProductGetDto>>(products), "Products listed");
    }

    public async Task<IDataResult<ProductGetDto>> GetByIdAsync(int id)
    {
        Product product = await _productRepository.GetAsync(p => p.Id == id && !p.IsDeleted);
        if (product is null)
        {
            return new ErrorDataResult<ProductGetDto>("Product is not found");
        };
        return new SuccessDataResult<ProductGetDto>(_mapper.Map<ProductGetDto>(product),"Product is found");
    }

    public async Task<IDataResult<ProductGetDto>> GetByNameAsync(string name)
    {
        Product product = await _productRepository.GetAsync(p => p.Name == name && !p.IsDeleted);
        if (product is null)
        {
            return new ErrorDataResult<ProductGetDto>("Product is not found");
        };
        return new SuccessDataResult<ProductGetDto>(_mapper.Map<ProductGetDto>(product), "Product is found");
    }

    public async Task<IResult> UpdateAsync(ProductUpdateDto productUpdateDto)
    {
        Product product = await _productRepository.GetAsync(p => p.Id == productUpdateDto.Id && !p.IsDeleted);
        if (product is null) throw new NotFoundException(Messages.ProductNotFound);
        _productRepository.Update(product);
        int result = await _productRepository.SaveAsync();
        if (result is 0)
        {
            return new ErrorResult("Product is not updated");
        }
        return new SuccessResult("Product is updated");
    }
}
