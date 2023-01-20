using Microsoft.VisualStudio.Services.FormInput;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace E_Apartments.Data
{
    public class Encrypt
    {
        public static string hash = "#svrg@35";         // The Encription Key
        public static string Encrypting(string input)
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(input);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { 
                    Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 
                })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    string output = Convert.ToBase64String(results, 0, results.Length);
                    return output;
                }
            }
        }
        public static string Decrypting(string EncryptedText)
        {
            byte[] data = Convert.FromBase64String(EncryptedText);
            using(MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { 
                    Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 
                })
                {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data,0, data.Length);
                    string output = UTF8Encoding.UTF8.GetString(results);
                    return output;
                }
            }
        }
    }
}
