var cities = new[] { "Austin", "New York", "San Francisco" };

for (var index = 0; index < cities.count(); index++)
{
    var city_List = cities[index];
    DoInitialActivities();
    DoSecondaryActivities();
    Dispatch(city_List);
}
