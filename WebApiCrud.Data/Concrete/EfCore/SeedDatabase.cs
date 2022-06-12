using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiCrud.Entity;

namespace WebApiCrud.Data.Concrete.EfCore
{

    public static class SeedDatabase
    {
        public static void Seed()
        {
            var context = new WebApiCrudContext();
            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Categories.Count() == 0)
                {
                    context.Categories.AddRange(Categories);
                }
                if (context.Products.Count() == 0)
                {
                    context.Products.AddRange(Products);
                }
                context.SaveChanges();
            }
        }

        private static Category[] Categories =
        {
            new Category() {CategoryId=1, CategoryName="Telefon",CategoryDescription="Ürünlerimiz son teknoloji ile üretilmektedir.",CategoryCreateDate=Convert.ToDateTime("2022-06-11 00:00:00")},
            new Category() {CategoryId=2, CategoryName="Bilgisayar",CategoryDescription="Ürünlerimiz son teknoloji ile üretilmektedir.",CategoryCreateDate=Convert.ToDateTime("2022-06-11 00:00:00")},
            new Category() {CategoryId=3, CategoryName="Beyaz Eşya",CategoryDescription="Ürünlerimiz son teknoloji ile üretilmektedir.",CategoryCreateDate=Convert.ToDateTime("2022-06-11 00:00:00")}

        };

        private static Product[] Products =
        {
            new Product {ProductId=1, CategoryId=1, ProductName="Samsung S10", ProductPrice=15000, ProductDescription="Bu telefon çok iyi bir telefon.", CreateDate=Convert.ToDateTime("2022-06-11 00:00:00")},
            new Product {ProductId=2, CategoryId=2, ProductName="Samsung S11", ProductPrice=16000, ProductDescription="Bu telefon çok iyi bir telefon.", CreateDate=Convert.ToDateTime("2022-06-11 00:00:00")},
            new Product {ProductId=3, CategoryId=3, ProductName="Samsung S12", ProductPrice=17000, ProductDescription="Bu telefon çok iyi bir telefon.", CreateDate=Convert.ToDateTime("2022-06-11 00:00:00")},
            new Product {ProductId=4, CategoryId=2, ProductName="Samsung S20", ProductPrice=18000, ProductDescription="Bu telefon çok iyi bir telefon.", CreateDate=Convert.ToDateTime("2022-06-11 00:00:00")},
            };
    }

}
