namespace BOL;

public class Product{
    private int prodId;
    private string prodName;
    private double price;
    private int avlbUnits;

    public Product(){

    }

    public Product(int prodId, string prodName, double price, int avlbUnits){
        this.prodId = prodId;
        this.prodName = prodName;
        this.price = price;
        this.avlbUnits = avlbUnits;
    }

    public int ProdId{
        get { return prodId; }
        set { this.prodId = value; }
    }

    public string ProdName{
        get { return prodName; }
        set { this.prodName = value; }
    }

    public double Price{
        get { return price; }
        set { this.price = value; }
    }

    public int AvlbUnits{
        get { return avlbUnits; }
        set { this.avlbUnits = value; }
    }
}