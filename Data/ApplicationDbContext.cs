using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VideoTravel.Models;
using VideoTravel.Models.Post;
using VideoTravel.Models.User;

namespace VideoTravel.Data;

public class ApplicationDbContext : IdentityDbContext<User>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    // Posts
    public DbSet<CategoryPosts> CategoryPosts { get; set; } = null!;
    public DbSet<SubCategoryPosts> SubCategoryPosts { get; set; } = null!;
    public DbSet<Post> Posts { get; set; } = null!;
    public DbSet<PostVideos> PostVideos { get; set; } = null!;

    // Tag
    public DbSet<Tag> Tags { get; set; } = null!;
}