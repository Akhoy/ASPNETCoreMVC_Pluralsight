using Microsoft.EntityFrameworkCore;
namespace MVCAppModels;

public class BethanysPieShopDbContext:DbContext
{
    public BethanysPieShopDbContext(DbContextOptions<BethanysPieShopDbContext> options):base(options)
    {
        
    }
    //expose entities (model classes) that we've already created in our application. we're going to expose the entities Pie and Category, that is, inside of the dbcontext as a dbset. This will allow us to work with these, and behind the scenes, they will be mapped to database tables later on and EFCore will make sure that the entities get loaded from the database and we'll also be able to save those if necessary. 

    // now by writing this, we've basically said to EFCore - these entities, I want you to match. It will therefore, be possible to load data in these DbSets and make changes to the data and then also let that updated data flow back to the database when we want to save changes back to the database. 
    public DbSet<Category> Categories{get;set;}
    public DbSet<Pie> Pies{get;set;}
}