namespace DAL;
using BOL;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

public class DBManager
{
    public static List<Product> GetAllProducts()
    {
        string jsonString = File.ReadAllText("../products.json");
        List<Product> newProductList = new List<Product>();
        newProductList = JsonSerializer.Deserialize<List<Product>>(jsonString);
        return newProductList;
    }

    public static bool SaveProduct(Product product){
         List<Product> productList = GetAllProducts();
        productList.Add(product);
        var productsJson = JsonSerializer.Serialize<List<Product>>(productList);
        File.WriteAllText("../products.json", productsJson);
        return true;
    }

    public static Product GetProductById(int Id){
        List<Product> productsList = GetAllProducts();
        var product = productsList.Find((prod) => { return prod.ProdId == Id; });
        return product as Product;
    }

    public static void DeleteById(int Id){
        List<Product> productsList = GetAllProducts();
        var product = productsList.Find((prod) => { return prod.ProdId == Id; });
        productsList.Remove(product);
        var productJson = JsonSerializer.Serialize<List<Product>>(productsList);
        File.WriteAllText("../products.json",productJson);
    }

}