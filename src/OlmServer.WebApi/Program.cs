using Microsoft.AspNetCore.Identity;
using OlmServer.Domain.AppEntities.Identity;
using OlmServer.WebApi.Configurations;
using OlmServer.WebApi.Middlewares;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.InstallServices(builder.Configuration, typeof(IServiceInstaller).Assembly);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    _ = app.UseSwagger();
    _ = app.UseSwaggerUI();
}
app.UseExceptionMiddleware();
app.UseHttpsRedirection();
app.UseAuthentication();

app.UseAuthorization();
app.UseCors();

app.MapControllers();
using (var scoped = app.Services.CreateScope())
{
    var userManager = scoped.ServiceProvider.GetRequiredService<UserManager<AppUser>>();
    if (!userManager.Users.Any())
    {
        userManager.CreateAsync(new AppUser
        {
            UserName = "babamerdan",
            Email = "demirci.irfan@gmail.com",
            Id = Guid.NewGuid().ToString(),
            NameLastName = "Ýrfan Demirci"
        }, "Password12*").Wait();
    }
}

app.Run();
