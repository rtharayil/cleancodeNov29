public class article
{
    public string state { get; set; }

 
}
 
public static void GetArticle(string article)
{
    if (article.state == "published")
    {
        // ...
    }
}