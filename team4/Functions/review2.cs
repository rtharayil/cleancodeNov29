var fullName = "Ryan McDermott";
 
public void PrintAsFirstNameAndLastName(string fullName)
{
    if (!string.IsNullOrEmpty(fullName))
    {
        var temp = fullName.Split(" ");
        if (temp.Length >= 2)
        {
            var formattedName = $"His first name is {temp[0]}, and his last name is {temp[1]}"; 
            Console.WriteLine(formattedName);
        }
        else
        {
            Console.WriteLine("Invalid full name format.");
        }
    }
    else
    {
        Console.WriteLine("Full name is null or empty.");
    }
}
