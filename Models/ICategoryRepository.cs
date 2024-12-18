using System;
namespace MVCAppModels;
public interface ICategoryRepository
{
    IEnumerable<Category> AllCategories {get;}
}
