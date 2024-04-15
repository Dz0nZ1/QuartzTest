namespace QuartzTest.Domain.Entities;

public class User
{
    public string FirstName { get; private set; } = string.Empty;

    public string LastName { get; private set; } = string.Empty;


    public User WithFirstName(string firstName)
    {
        FirstName = firstName;
        return this;
    }

    public User WithLastName(string lastName)
    {
        LastName = lastName;
        return this;
    }


}


