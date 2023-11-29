var name = "Ryan McDermott";
 
public void PrintAsFirstNameAndLastName()
{
    var splitName = name.Split(" ");
    var formattedName = $"His first name is {splitName[0]}, and his last name is {splitName[1]}"; 
    Console.WriteLine(formattedName);
}