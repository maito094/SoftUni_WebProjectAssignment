using AutomationShopHub.Infrastructure.Data;
using AutomationShopHub.ModelBinders;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options =>
{
   options.SignIn.RequireConfirmedAccount = builder.Configuration.GetValue<bool>("Identity:RequireConfirmedAccount");
   options.SignIn.RequireConfirmedEmail = builder.Configuration.GetValue<bool>("Identity:RequireConfirmedEmail"); ;
   options.SignIn.RequireConfirmedPhoneNumber = builder.Configuration.GetValue<bool>("Identity:RequireConfirmedPhoneNumber"); ;
   options.Password.RequireNonAlphanumeric = builder.Configuration.GetValue<bool>("Identity:RequireNonAlphanumeric"); ;
   options.Password.RequiredLength = builder.Configuration.GetValue<int>("Identity:RequiredLength"); ;

})
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.ConfigureApplicationCookie(options =>
{
   options.LogoutPath = "/Account/Logout";
   options.LoginPath = "/Identity/Account/Login"; // Change Default Login path. Without using Identity Razor Pages
});

builder.Services.AddControllersWithViews()
    .AddMvcOptions(options =>
{
   options.Filters.Add<AutoValidateAntiforgeryTokenAttribute>();
   options.ModelBinderProviders.Insert(0, new DecimalModelBinderProvider());
});
builder.Services.AddApplicationServices();

builder.Services.AddDistributedMemoryCache();

builder.Services.AddSession(options =>
{

   options.Cookie.HttpOnly = true;
   options.Cookie.IsEssential = true;
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
   app.UseDeveloperExceptionPage();
}
else
{
   app.UseExceptionHandler("/Home/Error");
   app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseSession();

app.UseEndpoints(endpoints =>
{

   endpoints.MapControllerRoute(
     name: "area",
     pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

   endpoints.MapControllerRoute(
     name: "addProduct",                                             // Route name
     pattern: "{area:exists}/{controller}/{action}/{product}"          // URL with parameters
         ); 
   endpoints.MapControllerRoute(
     name: "getProductDetails",                                             // Route name
     pattern: "{controller=Product}/{action=Details}/{guidId}"          // URL with parameters
         );
});


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages(); // Delete when no longer needed Identity

app.Run();
