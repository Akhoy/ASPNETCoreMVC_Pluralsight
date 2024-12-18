using System;
namespace MVCAppModels;
 public class Pie
    {
        public int PieId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? ShortDescription { get; set; }
        public string? LongDescription { get; set; }
        public string? AllergyInformation { get; set; }
        public decimal Price { get; set; }
        public string? ImageUrl { get; set; }
        public string? ImageThumbnailUrl { get; set; }
        public bool IsPieOfTheWeek { get; set; }
        public bool InStock { get; set; }
        public int CategoryId { get; set; }
        //default!: default initializes the property to its default value i.e. null.
        // For reference types, the default value is null. The ! (null-forgiving operator) tells the compiler to suppress warnings about nullability, indicating that you (the developer) know this value will be properly set before it is accessed, even though it's initialized to null now.
        public Category Category { get; set; } = default!;
    }


