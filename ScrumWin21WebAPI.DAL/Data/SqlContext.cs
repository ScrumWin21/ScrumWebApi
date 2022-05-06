using Microsoft.EntityFrameworkCore;
using ScrumWin21WebAPI.DAL.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumWin21WebAPI.DAL.Data
{
    public class SqlContext : DbContext
    {
        protected SqlContext()
        {
        }
        public SqlContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<UserEntity> Users { get; set; }
        public virtual DbSet<RoleEntity> Roles { get; set; }
        public virtual DbSet<AddressEntity> Addresses { get; set; }
        public virtual DbSet<ProductEntity> Products { get; set; }
        public virtual DbSet<CategoryEntity> Categories { get; set; }
        public virtual DbSet<OrderEntity> Orders { get; set; }
        public virtual DbSet<OrderLineEntity> OrderLines { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\aleks\Desktop\Scrum\ScrumBackend\ScrumWin21WebAPI.DAL\scrumLocalDB.mdf;Integrated Security=True;Connect Timeout=30");
        }

    }
}
