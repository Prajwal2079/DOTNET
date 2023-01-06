var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
List<string> names = new List<string>();
names.Add("Rohit");
names.Add("Rohit");
names.Add("Rohit");
names.Add("Rohit");
names.Add("Rohit");
names.Add("Rohit");
names.Add("Rohit");


var profile = new { ID = 25, FirstName = "Prajwal", LastName = "Patil" };

app.MapGet("/", () => "Hello World!");
app.MapGet("/profile", () => profile);
app.MapGet("/profile/list", () => names);

app.Run();
