using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace VIPService.Models {
    public class VIPDb : DbContext {
        public VIPDb()
            : base("DefaultConnection") {
        }
        public DbSet<VIP> Customers { get; set; }
        public DbSet<Record> Records { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Brand> Brands { get; set; }
    }
}