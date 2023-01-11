namespace BLL;
using BOL;
using DAL;

public class ProductManager{
    public static List<Product> GetAllProducts(){

        return DBManager.GetAllProducts();
    }

    // public static Product GetProductById(int id){
    //     return DBManager.GetProductById(id);
    // }

    public static bool DeleteProductById(int id){
        return false;
    }

    public static void InsertProduct(Product product){
        DBManager.SaveProduct(product);
    }
}