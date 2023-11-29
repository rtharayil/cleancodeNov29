var map= new Dictionary<string,string>();

map.add('777', 'Boing');

map.add('Air Force One', 'AirForceOne');

map.add('Cessna', 'Cessna');
 
abstract class Airplane

{

    string _type;

    // ...
 
    abstract public double GetCruisingAltitude();
 
}
 
class Cessna : Airplane

{

    public double GetCruisingAltitude()

    {

        return GetMaxAltitude() - GetFuelExpenditure();

    }

}
 
class AirForceOne : Airplane

{

    public double GetCruisingAltitude()

    {

        return GetMaxAltitude();

    }

}
 
class Boing : Airplane

{

    public double GetCruisingAltitude()

    {

        return GetMaxAltitude() - GetPassengerCount();

    }

}
