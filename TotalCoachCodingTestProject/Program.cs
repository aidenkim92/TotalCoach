using TotalCoachCodingTest.Repositories;
using TotalCoachCodingTestProject.Models.DataBase;
using TotalCoachCodingTestProject.Invitations.Repositories;
using TotalCoachCodingTestProject.Helpers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.Configure<UserDataBaseSettings>(
    builder.Configuration.GetSection("UserDatabase"));
builder.Services.Configure<InvitationDataBaseSettings>(
builder.Configuration.GetSection("InvitationDatabase"));
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IInvitationRepository, InvitationRepository>();
builder.Services.RegisterRequestHandlers();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();