public void SendEmail(string[] clients)
{
    foreach (var client in clients)
    {
        var record = clientsServer.Find(client);
        if (record.IsActive())
        {
            Email(client);
        }
    }
}