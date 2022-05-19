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
    }
}
