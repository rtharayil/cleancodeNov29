class Airplane
{
    string _type;
    // ...

     virtual public double GetCruisingAltitude()
    {
        // switch (_type)
        // {
        //     case '777':
        //         return GetMaxAltitude() - GetPassengerCount();
        //     case 'Air Force One':
        //         return GetMaxAltitude();
        //     case 'Cessna':
        //         return GetMaxAltitude() - GetFuelExpenditure();
        // }
    }
}


class Boeing777:Airplane {
    GetCruisingAltitude(){
        return logic;
    }
}