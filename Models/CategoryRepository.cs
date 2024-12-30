using Microsoft.EntityFrameworkCore;

namespace MVCAppModels;
public class CategoryRepository:ICategoryRepository
{   
    private readonly BethanysPieShopDbContext _bethanysPieShopDbContext;
    public CategoryRepository(BethanysPieShopDbContext bethanysPieShopDbContext)
    {
        // dbcontext will be injected by asp.net
        _bethanysPieShopDbContext = bethanysPieShopDbContext;
    }
    IEnumerable<Category> ICategoryRepository.AllCategories => _bethanysPieShopDbContext.Categories.OrderBy(p => p.CategoryName);
}