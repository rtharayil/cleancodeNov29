public static void DisplayFirstAndLastNames(string fullName)
{
    string[] names = fullName.Split(' ');

    if (names.Length >= 2)
    {
        string firstName = names[0];
        string lastName = names[1];

        Console.WriteLine($"His first name is {firstName}, and his last name is {lastName}");
    }
    else
    {
        Console.WriteLine($"Unable to determine first and last names for the given full name: {fullName}");
    }
}

public static void Main()
{
    string fullName = Console.WriteLine("Enter the name:");
    DisplaytFirstAndLastNames(fullName);
}