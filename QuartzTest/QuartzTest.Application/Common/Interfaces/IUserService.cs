using QuartzTest.Domain.Entities;

namespace QuartzTest.Application.Common.Interfaces;

public interface IUserService
{
    List<User> GetAllUsers();

    void AddUser();
}