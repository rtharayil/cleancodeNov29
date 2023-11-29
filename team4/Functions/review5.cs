public Path TravelToTexas(object vehicle)
{
    var texasLocation = new Location("texas");
    if (vehicle.GetType() == typeof(Bicycle))
    {
        // (vehicle as Bicycle).PeddleTo(new Location("texas"));
        vehicle.PeddleTo(texasLocation);
    }
    else if (vehicle.GetType() == typeof(Car))
    {
        // (vehicle as Car).DriveTo(new Location("texas"));
        vehicle.DriveTo(texasLocation);
    }
}
