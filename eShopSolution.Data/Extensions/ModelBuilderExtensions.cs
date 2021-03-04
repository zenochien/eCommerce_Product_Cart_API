using eShopSolution.Data.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;

namespace eShopSolution.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
               new AppConfig() { Key = "HomeTitle", Value = "This is home page of eShopSolution" },
               new AppConfig() { Key = "HomeKeyword", Value = "This is keyword of eShopSolution" },
               new AppConfig() { Key = "HomeDescription", Value = "This is description of eShopSolution" }
                 );
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 1,
                    Status = Status.Active,
                },
                 new Category()
                 {
                     Id = 2,
                     IsShowOnHome = true,
                     ParentId = null,
                     SortOrder = 2,
                     Status = Status.Active
                 });
            modelBuilder.Entity<CategoryTranslations>().HasData(
                 new CategoryTranslations() { Id = 1, CalegoryId = 1, Name = "Áo nam", SeoAlias = "ao-nam", SeoDescription = "Sản phẩm áo thời trang nam", SeoTitle = "Sản phẩm áo thời trang nam" },
                 new CategoryTranslations() { Id = 2, CalegoryId = 1, Name = "Men Shirt", SeoAlias = "men-shirt", SeoDescription = "The shirt products for men", SeoTitle = "The shirt products for men" },
                 new CategoryTranslations() { Id = 3, CalegoryId = 2, Name = "Áo nữ", SeoAlias = "ao-nu", SeoDescription = "Sản phẩm áo thời trang nữ", SeoTitle = "Sản phẩm áo thời trang women" },
                 new CategoryTranslations() { Id = 4, CalegoryId = 2, Name = "Women Shirt", SeoAlias = "women-shirt", SeoDescription = "The shirt products for women", SeoTitle = "The shirt products for women" }
                   );

            modelBuilder.Entity<Product>().HasData(
           new Product()
           {
               Id = 1,
               DateCreate = DateTime.Now,
               OriginalPrice = 100000,
               Price = 200000,
               Stock = 0,
               ViewCount = 0,
           });
            modelBuilder.Entity<ProductTranslations>().HasData(
                 new ProductTranslations()
                 {
                     Id = 1,
                     ProductId = 1,
                     Name = "Áo sơ mi nam trắng Việt Tiến",
                     SeoAlials = "ao-so-mi-nam-trang-viet-tien",
                     SeoDescription = "Áo sơ mi nam trắng Việt Tiến",
                     SeoTitle = "Áo sơ mi nam trắng Việt Tiến",
                     Details = "Áo sơ mi nam trắng Việt Tiến",
                     Description = "Áo sơ mi nam trắng Việt Tiến"
                 },
                new ProductTranslations()
                {
                    Id = 2,
                    ProductId = 1,
                    Name = "Viet Tien Men T-Shirt",
                    SeoAlials = "viet-tien-men-t-shirt",
                    SeoDescription = "Viet Tien Men T-Shirt",
                    SeoTitle = "Viet Tien Men T-Shirt",
                    Details = "Viet Tien Men T-Shirt",
                    Description = "Viet Tien Men T-Shirt"
                });
            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory() { ProductId = 1, CategoryId = 1 }
                );

            // any guid
            var roleId = new Guid("8D04DCE2-969A-435D-BBA4-DF3F325983DC");
            var adminId = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE");
            modelBuilder.Entity<AppRoles>().HasData(
                new AppRoles
                {
                    Id = roleId,
                    Name = "admin",
                    NormalizedName = "admin",
                    Description = "Administrator role"
                }, new AppRoles
                {
                    Id = new Guid("B00DB104-EDD6-4B9E-97B3-45433440592B"),
                    Name = "it",
                    NormalizedName = "It",
                    Description = "It"
                }
            );

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "chien.pm@gmail.com",
                NormalizedEmail = "chien.pm@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Abcd1234$"),
                SecurityStamp = string.Empty,
                FirstName = "chien",
                LastName = "pham",
                Dob = new DateTime(2021, 01, 31)
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId
            });
        }
    }
}
