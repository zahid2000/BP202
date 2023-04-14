namespace Business.Services.Abstract;

public interface IProductService
{
    Task<IDataResult<List<ProductGetDto>>> GetAllAsync();
    Task<IDataResult<ProductGetDto>> GetByIdAsync(int id);
    Task<IDataResult<ProductGetDto>> GetByNameAsync(string name);
    Task<IResult> CreateAsync(ProductCreateDto productCreateDto);
    Task<IResult> UpdateAsync(ProductUpdateDto productUpdateDto);
    Task<IResult> DeleteByIdAsync(int id);
}
