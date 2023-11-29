var city = new[] { "Austin", "New York", "San Francisco" };

for (var index = 0; index < city.count(); index++)
{
    var city_List = city[index];
    DoStuff();
    DoSomeOtherStuff();

    // ...
    // ...
    // ...
    // Wait, what is `li` for again?
    Dispatch(city_List);
}