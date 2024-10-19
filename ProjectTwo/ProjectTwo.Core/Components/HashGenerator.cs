using System;
using System.Security.Cryptography;
using System.Text;

namespace ProjectTwo.Core.Components
{
    internal class HashGenerator
    {
        public string Create(int N)
        {
            string input = generateString(N);
            string hash = generateHash(input);
            return hash;
        }

        public string generateHash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));

                string builder = "";
                foreach (byte b in bytes)
                {
                    builder += b.ToString("x2");
                }
                return builder;
            }
        }

        public string generateString(int N)
        {
            var rand = new Random();
            string new_str = "";
            string lang = "abcdefghijklmnopqrstuvwxyz";
            for (int i = 0; i < N; i++)
            {
                new_str += lang[rand.Next() % 26];
            }
            return new_str;
        }
    }
}
