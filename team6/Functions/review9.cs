public void SendEmailToActiveClients(string[] clientEmails)
{
    foreach (var clientEmail in clientEmails)
    {
        var clientRecord = db.Find(clientEmail);

        if (clientRecord != null && clientRecord.IsActive())
        {
            EmailSendingMethod(clientEmail, "Subject", "Body");
        }
    }
}
