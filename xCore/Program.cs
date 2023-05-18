using Microsoft.EntityFrameworkCore;
using xCore.Context;
using xCore.Repositories;
using xCore.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("Sql")));
builder.Services.AddScoped<CategoryRepo>();
builder.Services.AddScoped<AuthorRepo>();
builder.Services.AddScoped<ArticleRepo>();
builder.Services.AddScoped<ArticleService>();
builder.Services.AddScoped<AuthorServices>();

var app = builder.Build();


app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
