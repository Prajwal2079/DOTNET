using Mathematics;
using Grossery;
using ProdComparison;

MathEngine engine = new MathEngine();

engine.Addition(12, 32);
engine.Multiply(10, 20);

List<Products> productList = new List<Products>();

productList.Add(new Products(15, "Pin", "Multiple Pin"));
productList.Add(new Products(12, "Pen", "Black Color"));
productList.Add(new Products(14, "Pages", "A3 Size"));
productList.Add(new Products { ProductId = 12, PName = "Book", Description = "A4 size Book" });
productList.Add(new Products(16, "Pen", "Black Color"));
productList.Add(new Products(13, "SketchPen", "All Color"));

foreach (Products p in productList)
{
    Console.WriteLine(p);
}

ProductComparer pcom = new ProductComparer();

productList.Sort(pcom);
Console.WriteLine("******************************************");

foreach (Products p in productList)
{
    Console.WriteLine(p);
}

Console.WriteLine("******************************************");
List<Products> productList2 = new List<Products>();

productList2.Add(new Products(15, "Pin", "Multiple Pin"));
productList2.Add(new Products(12, "Pen", "Black Color"));
productList2.Add(new Products(14, "Pages", "A3 Size"));
productList2.Add(new Products { ProductId = 12, PName = "Book", Description = "A4 size Book" });
productList2.Add(new Products(16, "Pen", "Black Color"));
productList2.Add(new Products(13, "SketchPen", "All Color"));

foreach (Products p in productList2)
{
    Console.WriteLine(p);
}
productList2.Sort();
Console.WriteLine("******************************************");

foreach (Products p in productList2)
{
    Console.WriteLine(p);
}

string[] names = { "Prajwal", "Prajwal", "Suraj", "Sakshi", "Swanand", "Shruti", "Prashant" };

Console.WriteLine("TotalNames = " + names.Count());
Console.WriteLine("******************************************");
Console.WriteLine("Distinct Total = " + names.Distinct().Count());
Console.WriteLine("******************************************");
var take4 = names.Take(4);
foreach (string name in take4)
{
    Console.WriteLine("Four Names = " + name);
}
Console.WriteLine("******************************************");
var distinctTake4 = names.Distinct().Take(4);
foreach (string name in distinctTake4)
{
    Console.WriteLine("Four Distinct Names = " + name);
}
Console.WriteLine("******************************************");
var skip3 = names.Skip(3);
foreach (string name in skip3)
{
    Console.WriteLine("Skip First Three Names = " + name);
}
Console.WriteLine("******************************************");
var distinctSkip3 = names.Distinct().Skip(3);
foreach (string name in distinctSkip3)
{
    Console.WriteLine("Skip First Three Distinct Names = " + name);
}

Console.WriteLine("******************************************");
var selectedNames = from nm in names
                    where nm.Contains('j')
                    select nm;
foreach (string name in selectedNames)
{
    Console.WriteLine(name);
}