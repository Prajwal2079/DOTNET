namespace BOL;

public class Product
{

    public int ProductId { get; set; }
    public string Title { get; set; }
    public string Picture { get; set; }
    public string Description { get; set; }
    public int UnitPrice { get; set; }
    public int Available { get; set; }
    public int CategoryId { get; set; }
    public int UnitInStock { get; set; }
    public Product(){

    }

    public Product(int id, string title, string picture, string description, int unitprice, int categoryid, int unitinstock)
    {
        this.ProductId = id;
        this.Title = title;
        this.Picture = picture;
        this.Description = description;
        this.UnitPrice = unitprice;
        this.CategoryId = categoryid;
        this.UnitInStock = unitinstock;
    }


}