namespace MoneyFlow.Core.Handlers;

using MoneyFlow.Core.Models;    
using MoneyFlow.Core.Requests.Categories;
using MoneyFlow.Core.Responses;

public interface ICategoryHandler 
{
    Task<Response<Category?>> CreateAsync(CreateCategoryRequest request);
    Task<Response<Category?>> UpdateAsync(UpdateCategoryRequest request);
    Task<Response<Category?>> DeleteAsync(DeleteCategoryRequest request);
    Task<Response<Category?>> GetByIdAsync(GetCategoryByIdRequest request);
    Task<PagedResponse<List<Category>?>> GetAllAsync(GetAllCategoryRequest request);
}