using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC_Sample {
    public class CaesarCipher {
        private readonly char[] alphabet = "abcdefghijklmnopqrstufwxyzäöüABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789ÄÖÜ".ToCharArray();

        private readonly int shift;

        public CaesarCipher(int shift = 2) {
            this.shift = shift;
        }

        public string Encrypt(string plaintext) {
            var ciphertext = string.Empty;
            foreach (var c in plaintext) {
                if (char.IsWhiteSpace(c)) {
                    ciphertext += c;
                    continue;
                }

                var index = (Array.IndexOf(this.alphabet, c) + this.shift + this.alphabet.Length) % this.alphabet.Length;
                ciphertext += this.alphabet[index];
            }

            return ciphertext;
        }

        public string Decrypt(string ciphertext) {
            var plaintext = string.Empty;
            foreach (var c in ciphertext) {
                if (char.IsWhiteSpace(c)) {
                    plaintext += c;
                    continue;
                }

                var index = (Array.IndexOf(this.alphabet, c) - this.shift + this.alphabet.Length) % this.alphabet.Length;
                plaintext += this.alphabet[index];
            }

            return plaintext;
        }
    }

}
