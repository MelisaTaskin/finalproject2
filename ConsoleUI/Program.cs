using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{

    //SOLID 
    //Open Closed Principle 
    //diğer kodları bozmadan kod yazma 
    class Program

    {






        static void Main(string[] args)
        {
            //CategoryTest();



            ProductTest();

        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetProductDetails())

            {
                Console.WriteLine(product.productName + "/"+ product.CategoryName);
                Console.ReadLine();

            }
        }
    }

    //private static void /*CategoryTest()*/
    //    {
    //        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
    //        foreach (var category in categoryManager.GetAll())
    //        {
    //            Console.WriteLine(category.CategoryName);
    //        }
    //    }
    }
    //}