using EduSys.API.Filters;
using EduSys.API.Middlewares;
using EduSys.Core.Repositories;
using EduSys.Core.Services;
using EduSys.Core.UnitOfWorks;
using EduSys.Repository;
using EduSys.Repository.Repositories;
using EduSys.Repository.UnitOfWorks;
using EduSys.Service.Mapping;
using EduSys.Service.Services;
using EduSys.Service.Validations;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers().AddFluentValidation(x => x.RegisterValidatorsFromAssemblyContaining<ProductDtoValidator>());

builder.Services.AddControllers(options => options.Filters.Add(new ValidateFilterAttribute()));

builder.Services.Configure<ApiBehaviorOptions>(options =>
{
    options.SuppressModelStateInvalidFilter = true;
});
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped(typeof(NotFoundFilter<>));

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

builder.Services.AddAutoMapper(typeof(MapProfile));

builder.Services.AddScoped(typeof(IProductService), typeof(ProductService));
builder.Services.AddScoped(typeof(IProductRepository), typeof(ProductRepository));

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<ICategoryService, CategoryService>();

builder.Services.AddScoped(typeof(IService<>), typeof(Service<>));

builder.Services.AddDbContext<AppDbContext>(x =>
{
    x.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"), option =>
    {
        option.MigrationsAssembly(Assembly.GetAssembly(typeof(AppDbContext)).GetName().Name);
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCustomException();

app.UseAuthorization();

app.MapControllers();

app.Run();
