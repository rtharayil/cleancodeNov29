var cities = new[] { "Austin", "New York", "San Francisco" };

for (var index = 0; index < cities.Count(); i++)
{
    var city = cities[index];
    DoStuff();
    DoSomeOtherStuff();

    // ...
    // ...
    // ...
    // Wait, what is `li` for again?
    Dispatch(city);
}
