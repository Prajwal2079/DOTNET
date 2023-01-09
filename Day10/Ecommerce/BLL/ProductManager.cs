namespace BLL;
using BOL;
using DAL;

public class ProductManager{
    public static List<Product> GetAllProducts(){

        return DBManager.GetAllProducts();
    }

    public static Product GetProductById(int id){
        return DBManager.GetProductById(id);
    }

    public static void DeleteProductById(int id){
        DBManager.DeleteById(id);
    }

    public static void InsertProduct(Product product){
        DBManager.SaveProduct(product);
    }
}