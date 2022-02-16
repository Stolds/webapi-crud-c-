using CRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD.Data
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var user_model = modelBuilder.Entity<User>();
            user_model.ToTable("tb_user");
            user_model.HasKey(x => x.Id);
            user_model.Property(x => x.Id).HasColumnName("id").ValueGeneratedOnAdd();
            user_model.Property(x => x.Name).HasColumnName("name").IsRequired();
            user_model.Property(x => x.Hobby).HasColumnName("hobby").IsRequired(false);
        }
    }
}