public class Email
{
    //...
    public string _to;
    public string _subject;
    public string _body;
 
 
    public void send(string to, string subject, string body)
    {
        this._to = to;
        this._subject = subject;
        this._body = body;
        SendMail(this._to, this._subject, this._body);
    }
}
 
var message = new Email(...);
// What is this? A handle for the message? Are we writing to a file now?
message.send();