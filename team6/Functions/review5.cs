public Path TravelToTexas(object vehicle)
{
    if (vehicle.GetType() == typeof(Bicycle))
    {
        (Bicycle).PeddleTo(new Location("texas"));
    }
    else if (vehicle.GetType() == typeof(Car))
    {
        (Car).DriveTo(new Location("texas"));
    }
}
