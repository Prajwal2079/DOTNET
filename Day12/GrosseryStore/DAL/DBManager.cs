namespace DAL;
using BOL;
using MySql.Data.MySqlClient;

public class DBManager
{
    public static string conString = @"server=localhost;port=3306;user=root;password=root123;database=ecommerce";
    public static List<Product> GetAllProducts()
    {
        List<Product> newProductList = new List<Product>();
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conString;
        con.Open();

        try
        {
            string query = "SELECT * FROM products";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = int.Parse(reader["productid"].ToString());
                string title = reader["title"].ToString();
                string picture = reader["picture"].ToString();
                string description = reader["description"].ToString();
                int unitprice = int.Parse(reader["unitprice"].ToString());
                // int available = int.Parse(reader["available"].ToString());
                int categoryid = int.Parse(reader["categoryid"].ToString());
                int unitinstock = int.Parse(reader["unitinstock"].ToString());

                Product newProd = new Product(id, title, picture, description, unitprice,categoryid, unitinstock);
                Console.WriteLine(newProd.ProductId);
                newProductList.Add(newProd);
            }

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            con.Close();
        }
        return newProductList;
    }

    public static bool SaveProduct(Product product)
    {
        List<Product> productList = GetAllProducts();

        return true;
    }

    // public static Product GetProductById(int Id){
    //     List<Product> productsList = GetAllProducts();
    //     return product as Product;
    // }

}