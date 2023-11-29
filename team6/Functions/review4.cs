[1:58 PM] Loganath, Mamatha
4.
abstract class Airplane

{

    public abstract double GetCruisingAltitude();

}
 
class Boeing777 : Airplane

{

    public override double GetCruisingAltitude()

    {

        return GetMaxAltitude() - GetPassengerCount();

    }

}
 
class AirForceOne : Airplane

{

    public override double GetCruisingAltitude()

    {

        return GetMaxAltitude();

    }

}
 
class Cessna : Airplane

{

    public override double GetCruisingAltitude()

    {

        return GetMaxAltitude() - GetFuelExpenditure();

    }

}
