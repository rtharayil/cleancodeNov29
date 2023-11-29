var cities = new[] { "Austin", "New York", "San Francisco" };

for (var ind = 0; ind < cities.Count(); ind++)
{
    var currentCity = cities[ind];
    DoStuff();
    DoSomeOtherStuff();

    // ...
    // ...
    // ...
    // Wait, what is `li` for again?
    Dispatch(currentCity);
}