namespace Grossery;

public class Products:IComparable{
    public int ProductId{ get; set; }
    public string PName{ get; set; }
    public string Description{get; set;}
    public Products(){

    }

    public Products(int id, string pname, string desc){
        this.ProductId = id;
        this.PName = pname;
        this.Description = desc;
    }

    public int CompareTo(object? prod1){

        if(this.ProductId > ((Products)prod1).ProductId){
            return 1;
        }
        else if(this.ProductId < (prod1 as Products).ProductId){
            return -1;           
        }
        return 0;
    }

    public override string ToString()
    {
        return $"Product ID: {ProductId} --- Product Name:{PName} --- Description: {Description}";
    }

    public override int GetHashCode()
    {
        return this.ProductId;
    }
}

