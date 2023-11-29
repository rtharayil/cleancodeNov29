
var name = "Ryan McDermott";

public void PrintAsFirstNameAndLastName(var name)
{
    var nameParts = name.Split(" ");
    // name = $"His first name is {temp[0]}, and his last name is {temp[1]}"; 
    Console.WriteLine($"His first name is {nameParts[0]}, and his last name is {nameParts[1]}");
}

// PrintAsFirstNameAndLastName(ryanName)