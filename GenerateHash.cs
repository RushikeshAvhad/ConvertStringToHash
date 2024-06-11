using System.Security.Cryptography;
using System.Text;

namespace ConvertStringToHash
{
    public static class GenerateHash
    {
        public static void GenerateMD5Hash()
        {
            Console.WriteLine("Enter your string to Convert to Hash");

            string input = Console.ReadLine();

            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("x2")); // "X2" for uppercase hex, "x2" for lowercase
                }

                string hash = sb.ToString();
                Console.WriteLine("The Hash value for {0} is {1} ", input, hash);
            }
        }
    }
}
