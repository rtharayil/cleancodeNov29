class Airplane
{
    private string airplaneType;

    private Dictionary<string, Func<double>> altitudeCalculations;

    public Airplane(string type)
    {
        airplaneType = type;

        altitudeCalculations = new Dictionary<string, Func<double>>
        {
            { "777", () => GetMaxAltitude() - GetPassengerCount() },
            { "Air Force One", () => GetMaxAltitude() },
            { "Cessna", () => GetMaxAltitude() - GetFuelExpenditure() },
        };
    }
}