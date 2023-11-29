// with out creating object calling method cryptographer.decrypt(codedPhrase, password); leading to null pointer
// cryptographer.decrypt(user.getPhraseEncodedByPassword(), password); Directly we can use this no need of extra variable
// "Valid Password".equals(cryptographer.decrypt(user.getPhraseEncodedByPassword(), password)
// Not formatted

package CS1;

public class UserValidator {

    private Cryptographer cryptographer;

    public boolean checkPassword(String userName, String password) {
        User user = UserGateway.findByName(userName);

        if (user != null) {

            String codedPhrase = user.getPhraseEncodedByPassword();

            String phrase = cryptographer.decrypt(codedPhrase, password);

            if ("Valid Password".equals(phrase)) {

                session.initialize();

                return true;
            }


        }
        
    
        return false;
    }


}
