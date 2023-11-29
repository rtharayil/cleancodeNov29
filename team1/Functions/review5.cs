public void  TravelToTexas(object vehicle)
{
   if(vehicle.GetType() == typeof(Bicycle))
   {
        (vehicle as Bicycle).PeddleTo(new Location("texas"));
        return;
   }
   else if (vehicle.GetType == typeof(car))
   {
        (vehicle as car).DriveTo(new Location("texas"));
        return;
   }
   
   throw new ArgumentException("Unsupported vehicle type");
   
}