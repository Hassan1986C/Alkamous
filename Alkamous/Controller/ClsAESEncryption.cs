using System.IO;
using System.Security.Cryptography;

namespace Alkamous.Controller
{
    public static class ClsAESEncryption
    {

        public static byte[] AESEncrypt(string plaintext, byte[] key, byte[] iv)
        {
            using (Aes aes = Aes.Create())
            {
                aes.KeySize = 256;
                aes.BlockSize = 128;
                aes.Key = key;
                aes.IV = iv;
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;

                // Create an encryptor to perform the AES encryption
                ICryptoTransform encryptor = aes.CreateEncryptor();

                // Convert the plaintext message to a byte array
                byte[] plaintextBytes = System.Text.Encoding.UTF8.GetBytes(plaintext);

                // Encrypt the message
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        cs.Write(plaintextBytes, 0, plaintextBytes.Length);
                    }
                    return ms.ToArray();
                }
            }
        }

        public static string AESDecrypt(byte[] encryptedMessage, byte[] key, byte[] iv)
        {
            using (Aes aes = Aes.Create())
            {
                aes.KeySize = 256;
                aes.BlockSize = 128;
                aes.Key = key;
                aes.IV = iv;
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;

                // Create a decryptor to perform the AES decryption
                ICryptoTransform decryptor = aes.CreateDecryptor();

                // Decrypt the message
                using (MemoryStream ms = new MemoryStream(encryptedMessage))
                {
                    using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader reader = new StreamReader(cs))
                        {
                            return reader.ReadToEnd();
                        }
                    }
                }
            }
        }
    }



}

