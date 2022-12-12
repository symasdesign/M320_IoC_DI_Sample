using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC_Sample {

    public class User {
        public User(string username, string password) {
            this.Username = username;
            this.password = password;
        }
        private string password;
        public string Username { get; set; }
        public string PasswordEncrypted {
            get {
                var cipher = new CaesarCipher(10);
                return cipher.Encrypt(this.password);
            }
        }
    }
}
