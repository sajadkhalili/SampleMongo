using Microsoft.Extensions.Configuration;
using WebApplication1.AppService;
using WebApplication1.Attributes.Contract;
using WebApplication1.Attributes.ContractService;
using WebApplication1.Infra;
using WebApplication1.Mit.Store.Catalog.MongoDB.Commons;
using WebApplication1.Pages;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();


builder.Services.Configure<MongoConnectionOptions>(
     builder.Configuration.GetSection("MongoConnection"));
builder.Services.AddSingleton<MongoConnectionOptions>();
builder.Services.AddScoped<TestContextMongoContext>();
builder.Services.AddScoped<IAttributeService,AttributeService>();
builder.Services.AddScoped<IAttributeRepository, AttributeRepository>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();
app.MapControllers();

app.Run();
