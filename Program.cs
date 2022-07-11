using TestApply.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();

var app = builder.Build();
app.UseRouting();

app.UseHttpsRedirection();
app.UseStaticFiles();
app.MapRazorPages();
app.MapControllers();

app.Run();

public class Global {
    public static List<Order> lstOrder { get; set; }
}
