package CS1;

public class UserValidator
{

    private Cryptographer cryptographer; //Give a different name otherthan the class

    public boolean checkPassword(String userName, String password)
    {
        User user = UserGateway.findByName(userName);

        if (user != null)
        {

            String codedPhrase = user.getPhraseEncodedByPassword();

            String phrase = cryptographer.decrypt(codedPhrase, password);//decryptedPhrase

            if ("Valid Password".equals(phrase)) //Should have custom string for password
            {

                session.initialize();

                return true;
            }


        }


        return false;
    }