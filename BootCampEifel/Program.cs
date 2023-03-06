using BootCampEifel.DataAccess.Context;
using BootCampEifel.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Database Setup
string connectionString = builder.Configuration.GetConnectionString("EscuelaConnection");

Environment.SetEnvironmentVariable("Connection", connectionString);
builder.Services.AddDbContext<SchoolSystemContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("EscuelaConnection"));
});


#region Repositories Registry

builder.Services.AddScoped<IContactsRepository, ContactsRepsitory>();

#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.s
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
