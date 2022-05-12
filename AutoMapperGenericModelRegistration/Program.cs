using AutoMapperGenericModelRegistration.Extensions;
using AutoMapperGenericModelRegistration.InterfaceMarker;
using AutoMapperGenericModelRegistration.Model;
using AutoMapperGenericModelRegistration.Repository;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<ICustomerRepository, CustomerRepository>();
builder.Services.AddTransient<IProductRepository, ProductRepository>();
builder.Services.AddAutoMapper(typeof(Program));


var typeToRegister = new List<Type>();
var dataAssembly = Assembly.GetExecutingAssembly();
typeToRegister.AddRange(dataAssembly.DefinedTypes.Select(x => x.AsType()));

//foreach (var builderType in typeToRegister.Where(x => typeof(ISourceMarker).IsAssignableFrom(x)))
//{
//    if (builderType != null && builderType != typeof(IEntityBuilder))
//    {
//        var builder = (IEntityBuilder)Activator.CreateInstance(builderType);
//        builder.Builder(modelBuilder);
//    }
//}

//var types = Assembly.GetExecutingAssembly().GetTypes().Where(mytype => mytype.GetInterfaces().Contains(typeof(IMapFrom<>))).ToList();


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
