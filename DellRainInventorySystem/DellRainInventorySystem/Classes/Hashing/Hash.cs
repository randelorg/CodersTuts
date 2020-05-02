using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DellRainInventorySystem.Classes.Hashing
{
    internal class Hash
    {
        private const string SecretKey = "PogiSiRandel6969";

        public static string Encode(string passwordToEncode)
        {
            byte[] clearBytes = Encoding.Unicode.GetBytes(passwordToEncode);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(SecretKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    passwordToEncode = Convert.ToBase64String(ms.ToArray());
                }
            }
            return passwordToEncode;
        }

        public static string Decode(string passwordToDecode)
        {
            byte[] cipherBytes = Convert.FromBase64String(passwordToDecode);
            using (Aes encryptor = Aes.Create())
            {
                AesManaged aes = new AesManaged();
                aes.Padding = PaddingMode.Zeros;

                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(SecretKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    passwordToDecode = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return passwordToDecode;
        }
    }
}
