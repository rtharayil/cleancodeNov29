var name = "Ryan McDermott";
 
public void PrintAsFirstNameAndLastName()
{
    var temp = name.Split(" ");
    var firstName= temp[0];
    var lastName= temp[1]
    name = $"His first name is {firstName}, and his last name is {lastName}";
    Console.WriteLine(name);
}
