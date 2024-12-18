namespace MVCAppModels;

public class Category
    {
    private List<Pie>? pies;
    private string? description;
    private string categoryName = string.Empty;
    private int categoryId;

    public int CategoryId { get => categoryId; set => categoryId = value; }
    public string CategoryName { get => categoryName; set => categoryName = value; }
    public string? Description { get => description; set => description = value; }
    public List<Pie>? Pies { get => pies; set => pies = value; }
}
