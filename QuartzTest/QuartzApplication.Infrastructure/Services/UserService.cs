using QuartzTest.Application.Common.Interfaces;
using QuartzTest.Domain.Entities;

namespace QuartzApplication.Infrastructure.Services;

public class UserService : IUserService
{
    public List<User> allUsers =
    [
        new User().WithFirstName("Nikola").WithLastName("Nikolic"),
        new User().WithFirstName("Petar").WithLastName("Petrovic"),
        new User().WithFirstName("Stefan").WithLastName("Stefanovic")
    ];

    public void AddUser()
    {
        allUsers.Add(new User().WithFirstName("Marko").WithLastName("Markovic"));
    }
    
    public List<User> GetAllUsers()
    {
        return allUsers;
    }
}