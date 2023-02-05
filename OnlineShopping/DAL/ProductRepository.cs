
using BOL;
using System.Text.Json;
using System.IO;

namespace DAL;

public  static class ProductRepository
{
    public static  List<Product> GetAll()
    {
            List<Product> allProducts=new List<Product>();
            allProducts.Add(new Product { ProductId = 1, Title = "Gerbera", Description = "Wedding Flower", UnitPrice = 6, Category = "Flower", StockAvailable = 5000 });
            allProducts.Add(new Product { ProductId = 2, Title = "Rose", Description = "Valentine Flower", UnitPrice = 15, Category = "Flower", StockAvailable = 7000 });
            allProducts.Add(new Product { ProductId = 3, Title = "Lotus", Description = "Worship Flower", UnitPrice = 26, Category = "Flower", StockAvailable = 3400 });
            allProducts.Add(new Product { ProductId = 4, Title = "Carnation", Description = "Pink carnations signify a mother's love, red is for admiration and white for good luck", UnitPrice = 16, Category = "Flower", StockAvailable = 27000 });
            allProducts.Add(new Product { ProductId = 5, Title = "Lily", Description = "Lilies are among the most popular flowers in the U.S.", UnitPrice = 6, Category = "Flower", StockAvailable = 1000 });
            return allProducts;
    }

    public static Product GetById(int id)
    {
          System.Console.WriteLine("Repository recived.");
          List<Product> products=GetAll();
          var theProduct= from prod in products
                          where prod.ProductId == id
                          select prod;

          return theProduct.First<Product>();
    }

    public  static bool  Insert(Product product){
         bool status=false;
         List<Product> products=GetAll();
         products.Add(product);
         status=true;
         return status;
    }


    public  static bool Delete(int id){
         bool status=false;
         List<Product> products=GetAll();
         Product theProduct=GetById(id);
         products.Remove(theProduct);
         status=true;
         return status;
    }


    public static bool Update(Product product)
    {
         bool status=false;
         List<Product> products=GetAll();
         status=true;
         return status;
    }

}
