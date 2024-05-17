using SearchService;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();
app.UseAuthorization();
app.MapControllers();
try
{
    await DbIntializer.InitDB(app);
}
catch (Exception e)
{
    Console.WriteLine(e);
}

app.Run();

