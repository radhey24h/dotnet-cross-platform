using oops_and_basics;

public static class ExtensionMethod
{
    public static string ExtendAddName(this Person cls, string firstName, string lastName)
    {
        return firstName + " " + lastName;
    }

}