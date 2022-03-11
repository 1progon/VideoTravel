using System.ComponentModel.DataAnnotations;

namespace VideoTravel.Models.Post;

public class CategoryPosts : BaseModel
{
    [Key] public override long Id { get; set; }
    
    public IList<SubCategoryPosts>? SubCategories { get; set; }
}