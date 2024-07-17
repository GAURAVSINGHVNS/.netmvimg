using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace mvcimg.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("xyz")
        {

        }
        public DbSet<tblregistration> tblregistrations { get; set; }
    }
}