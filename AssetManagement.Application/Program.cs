using AssetManagement.Application.Common.Credential;
using AssetManagement.Application.ConfigurationOptions;
using AssetManagement.Application.Extensions;
using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;

var builder = WebApplication.CreateBuilder(args);




//Configure variable
var appSettings = new AppSetting();
builder.Configuration.Bind(appSettings);

builder.Services.Configure<AppSetting>(builder.Configuration);

// Add services to the container.
builder.Services.ConfigureCors();
builder.Services.ConfigureAutoMapper();
builder.Services.ConfigureSwagger();
builder.Services.RegisterServiceDependencies();
builder.Services.RegisterRepositoryDependencies();
builder.Services.ConfigureDatabase(appSettings);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();


builder.Services.AddSpaStaticFiles(configuration =>
{
    configuration.RootPath = "Frontend";
});

builder.Services.AddExceptionHandler<GlobalExceptionHandler>();

builder.Services.AddAuthentication(builder.Configuration);

var app = builder.Build();

app.UseExceptionHandler(_ => { });
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.ConfigObject.AdditionalItems.Add("persistAuthorization", "true");
    });
}


app.UseSpaStaticFiles();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseHttpsRedirection();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.UseSpa(spa =>
{
    spa.Options.SourcePath = "Frontend";

    if (app.Environment.IsDevelopment())
    {
        //spa.UseProxyToSpaDevelopmentServer("http://localhost:3000");
        spa.UseReactDevelopmentServer(npmScript: "start");
    }
});


app.Run();
