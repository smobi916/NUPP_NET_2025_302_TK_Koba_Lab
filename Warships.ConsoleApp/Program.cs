using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Warships.ConsoleApp.Interfaces;
using Warships.ConsoleApp.Services;
using Warships.Infrastructure;
using Warships.Infrastructure.Models;

var builder = new ConfigurationBuilder()
    .AddJsonFile("../Warships.Infrastructure/appsettings.json")
    .Build();

var services = new ServiceCollection();
services.AddDbContext<WarshipContext>(options =>
    options.UseSqlite(builder.GetConnectionString("DefaultConnection")));
services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
services.AddScoped(typeof(ICrudServiceAsync<>), typeof(CrudServiceAsync<>));
var provider = services.BuildServiceProvider();

var crudService = provider.GetRequiredService<ICrudServiceAsync<WarshipModel>>();

while (true)
{
    Console.WriteLine("\n1. ������ ��������\n2. �������� ��\n3. �����");
    var input = Console.ReadLine();
    if (input == "1")
    {
        Console.Write("�����: ");
        var name = Console.ReadLine();
        Console.Write("���: ");
        var type = Console.ReadLine();

        var warship = new WarshipModel
        {
            Id = Guid.NewGuid(),
            Name = name ?? "",
            Type = type ?? "",
            Captain = new CaptainModel
            {
                Id = Guid.NewGuid(),
                Name = "������ " + name
            },
            CrewMembers = new List<CrewMemberModel>
            {
                new CrewMemberModel { Id = Guid.NewGuid(), FullName = "Crew 1" },
                new CrewMemberModel { Id = Guid.NewGuid(), FullName = "Crew 2" }
            }
        };

        await crudService.CreateAsync(warship);
    }
    else if (input == "2")
    {
        var all = await crudService.ReadAllAsync();
        foreach (var item in all)
            Console.WriteLine($"��������: {(item as WarshipModel)?.Name}, ���: {(item as WarshipModel)?.Type}");
    }
    else break;
}