using Grossery;
namespace ProdComparison;

public class ProductComparer:IComparer<Products>{
    public int Compare(Products? prod1, Products? prod2)
    {
        if(prod1.ProductId > prod2.ProductId){
            return 1;
        }
        else if(prod1.ProductId < prod2.ProductId){
            return -1;
        }
        return 0;
    }

}