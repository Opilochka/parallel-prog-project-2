using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace ProjectTwo.Core.Components
{
    internal class HashGenerator
    {
        public string generateHash(int N)
        {
            byte[] bytes = new byte[N];
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(bytes);
            }

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hash_bytes = sha256.ComputeHash(bytes);
                string builder = "";
                foreach (byte b in bytes)
                {
                    builder += b.ToString("x2");
                }
                return builder.Substring(0, N);
            }
        }
    }
}
