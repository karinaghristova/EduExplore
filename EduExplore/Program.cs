var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplicationDbContexts(builder.Configuration);
// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddApplicationServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

//Home
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

//School
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=School}/{action=AllSchools}/{page?}/{pageSize?}");
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=School}/{action=AllSchoolsByInhabitedArea}/{id}/{page?}/{pageSize?}");
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=School}/{action=AllSchoolsByRegion}/{id}/{page?}/{pageSize?}");
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=School}/{action=AllSchoolsByInstitutionType}/{id}/{page?}/{pageSize?}");
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=School}/{action=AllSchoolsByDetailedInstitutionType}/{id}/{page?}/{pageSize?}");
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=School}/{action=AllSchoolsByFinancialType}/{id}/{page?}/{pageSize?}");

//Kindergarten
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Kindergarten}/{action=AllKindergartens}/{page?}/{pageSize?}");
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Kindergarten}/{action=AllKindergartensByInhabitedArea}/{id}/{page?}/{pageSize?}");
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Kindergarten}/{action=AllKindergartensByRegion}/{id}/{page?}/{pageSize?}");
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Kindergarten}/{action=AllKindergartensByFinancialType}/{id}/{page?}/{pageSize?}");
/*app.MapRazorPages()*/
;

app.Run();
