public class Email
{
    //...
     private string _to;
    private string _subject;
    private string _body;
 
    public Email(string to, string subject, string body)
    {
        _to = to;
        _subject = subject;
         _body = body;
    }
 
    public void Send()
    {
        SendMail(this._to, this._subject, this._body);
    }
 
    private void SendMail(string to, string subject, string body)
    {
        //logic
    }
}

var email = new Email("to", "Subject ", "Body ");
 
email.Send();