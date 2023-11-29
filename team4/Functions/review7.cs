class DBConnection
{
    private static DBConnection _instance;
 
    private DBConnection()
    {
        // ...
    }
 
    public static DBConnection GetInstance() // no return type
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
