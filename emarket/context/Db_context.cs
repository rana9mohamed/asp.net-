using emarket.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace emarket.context
{
    public class Db_context : DbContext
    {
        public DbSet<products> products { get; set; }
        public DbSet<categories> categories { get; set; }
    }
}