using System;
 
public void SendEmailToClients(string[] clients)
{
    foreach (var client in clients)
    {
        var record = db.Find(client);
        if (record.IsActive())
        {
            Email(client);
        }
        else
        {
            Console.WriteLine("Record not active", client);
        }
    }
}