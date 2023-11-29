public void SendEmailToListOfClients(string[] clients)
{
    foreach (var client in clients)
    {
        var clientRecord = db.Find(client);
        clientRecord.IsActive() ? Email(Client) : null;
    }
}