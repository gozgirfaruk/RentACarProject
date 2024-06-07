using RentACarProject.CqrsPattern.Handlers;
using RentACarProject.DAL;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<RentContext>();

builder.Services.AddScoped<GetRentCarQueryHandler>();
builder.Services.AddScoped<CreateRentCarCommandHandler>();
builder.Services.AddScoped<RemoveRentCarCommandHandler>();
builder.Services.AddScoped<GetRentCarByIdQueryHandler>();
builder.Services.AddScoped<UpdateRentCarCommandHandler>();
builder.Services.AddScoped<GetRentCarGreenQueryHandler>();
builder.Services.AddScoped<GetRentCarRedQueryHandler>();

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies
(Assembly.GetExecutingAssembly()));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
