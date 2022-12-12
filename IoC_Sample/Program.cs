namespace IoC_Sample {
    public class Program {
        public static void Main(string[] args) {
            CaesarCipher cipher = new CaesarCipher(10);
            User max = new User("max", "geheim");
            System.Console.WriteLine($"Encrypted Password of max is '{max.PasswordEncrypted}' (decrypted: '{cipher.Decrypt(max.PasswordEncrypted)}')");
        }
    }
}