
using Microsoft.EntityFrameworkCore;

namespace MVCAppModels;
public class PieRepository:IPieRepository
{
    // use dependency injection and declare a dbcontext instance
    private readonly BethanysPieShopDbContext _bethanysPieShopDbContext;
    public PieRepository(BethanysPieShopDbContext bethanysPieShopDbContext)
    {
        // dbcontext will be injected by asp.net
        _bethanysPieShopDbContext = bethanysPieShopDbContext;
    }

    // implementing IPieRepository properties
    IEnumerable<Pie> IPieRepository.AllPies
    {
        get{
            return _bethanysPieShopDbContext.Pies.Include(c => c.Category);
        }
    }
        

    IEnumerable<Pie> IPieRepository.PiesOfTheWeek 
    {
        get{
            return _bethanysPieShopDbContext.Pies.Include(c => c.Category).Where(p=>p.IsPieOfTheWeek);
        }
    }

    Pie? IPieRepository.GetPieById(int pieId)
    {
        return _bethanysPieShopDbContext.Pies.FirstOrDefault(p => p.PieId == pieId);
    }
}