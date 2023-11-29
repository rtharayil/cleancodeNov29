class DBConnection
{
    private static DBConnection _instance;

    private DBConnection() //constructor
    {
        // ...
    }

    public static GetInstance()  //add a return address like class
    {
        if (_instance == null)
        {
            _instance = new DBConnection();
        }

        return _instance;
    }

    // ...
}

var singleton = DBConnection.GetInstance();