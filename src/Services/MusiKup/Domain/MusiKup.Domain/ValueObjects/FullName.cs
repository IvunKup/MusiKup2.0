namespace MusiKup.Domain.ValueObjects;

public class FullName
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string? MiddleName { get; set; }

    public FullName(string firstName, string lastName, string? middleName)
    {
        FirstName = firstName;
        LastName = lastName;
        MiddleName = middleName;
    }


    public FullName()
    {
    }
}