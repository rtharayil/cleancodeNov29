var fullName = "Ryan McDermott";
 
public void PrintNameDetails(var fullname)
{
    var nameParts = fullName.Split(" ");
    if (nameParts.Length == 2)
    {
        var formattedName = $"His first name is {nameParts[0]}, and his last name is {nameParts[1]}";
        Console.WriteLine(formattedName);
    }
    else
    {
        Console.WriteLine("Invalid name format: Expected first and last name.");
    }
}

