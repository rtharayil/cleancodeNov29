// class Airplane
// {
//     string _type;
//     // ...

//     public double GetCruisingAltitude()
//     {
//         switch (_type)
//         {
//             case '777':
//                 return GetMaxAltitude() - GetPassengerCount();
//             case 'Air Force One':
//                 return GetMaxAltitude();
//             case 'Cessna':
//                 return GetMaxAltitude() - GetFuelExpenditure();
//         }
//     }
// }

class Airplane
{
    string _type;
    // ...
    Dictionary<string, System.Delegate> cruisingAltitudeActions = new Dictionary<string, Systems.Delegate>(){
        {'777', new Action(() => GetMaxAltitude() - GetPassengerCount())},
        {'Air Force One', new Action(() => GetMaxAltitude())},
        {'Cessna', new Action(() => GetMaxAltitude() - GetFuelExpenditure())}
    }


    

    public double GetCruisingAltitude()
    {
        return cruisingAltitudeActions[_type]()
    }
}