 
var cities = new[] { "Austin", "New York", "San Francisco" };

for (var i = 0; i < cities.Count(); i++)
{
    var city = cities[i];
    Action();
    AlternateAction();
 
    // ...
    // ...
    // ...
    // Wait, what is `li` for again?
    Dispatch(city);
}