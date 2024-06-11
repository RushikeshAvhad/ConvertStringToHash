using System.Security.Cryptography;
using System.Text;

namespace ConvertStringToHash
{
    public static class GenerateHash
    {
        public static string GenerateMD5Hash(string input)
        {
            // Create an instance of the MD5CryptoServiceProvider class
            using (MD5 md5 = MD5.Create())
            {
                // Convert the input string to a byte array and compute the hash
                byte[] inputBytes = Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to a hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("x2")); // "X2" for uppercase hex, "x2" for lowercase
                }

                return sb.ToString();
            }
        }
    }
}
