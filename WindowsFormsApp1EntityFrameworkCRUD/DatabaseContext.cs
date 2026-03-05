using System.Data.Entity;
using WindowsFormsAppAdoNetCRUD; // entity framework kullanabilmek için gerekli

namespace WindowsFormsApp1EntityFrameworkCRUD
{
    internal class DatabaseContext : DbContext // DbContext sınıfı entity framework paketiyle birlikte gelir
    {
        public virtual DbSet<Category> Categories { get; set; } // dbset tanımlayarak ver,tabanındaki tabloları sembolize ediyoruz
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
