package CS1; //what is CS1
 
public class UserValidator {
 
    private Cryptographer cryptographer;
 
    public boolean checkPassword(String userName, String password) {
        User user = UserGateway.findByName(userName); /// UserGateway is invalid object.
 
        if (user != null)
        {
            String codedPhrase = user.getPhraseEncodedByPassword();
 
            String phrase = cryptographer.decrypt(codedPhrase, password);
 
            if ("Valid Password".equals(phrase)) {  // constant string does not have methods.
 
                session.initialize();   /// session is invalid object.
 
                return true;
            }
        }
        return false;
    }
 
}