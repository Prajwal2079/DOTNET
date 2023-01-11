namespace BOL;

public class Department
{

    public int Id { get; set; }
    public string? Name { get; set; }  //naullable type
    public string? Location { get; set; }

public Department(){

}
    public Department(int id, string name, string location)
    {
        this.Id = id;
        this.Name = name;
        this.Location = location;
    }
}