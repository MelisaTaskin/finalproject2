using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    //context nesnesi Db tabloları ile proje classlarını bağlar 
   public  class NorthWindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = (localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }


        internal object Set<T>(Expression<Func<T, bool>> filter)
        {
            throw new NotImplementedException();
        }

        //internal object Set<T>(Expression<Func<T, bool>> filter)
        //{
        //    throw new NotImplementedException();
        //}

        //internal object Set<T>(Expression<Func<T, bool>> filter)
        //{
        //    throw new NotImplementedException();
        //}
    }   
}
