using System;
using System.CodeDom.Compiler;

namespace ProjectTwo.Core.Components
{
    internal class Mainer
    {
        public void Launch(int N, string target_hash)
        {
            hashSelection(N, target_hash);
        }

        public void hashSelection(int N, string target_hash)
        {
            string hash_symbols = "0123456789abcdef";
            int num_combinations = (int)Math.Pow(hash_symbols.Length, N);
            for (int i = 0; i < num_combinations; i++)
            {
                string tmp = generateHashString(i, N, hash_symbols);
                Console.WriteLine(tmp);
            }
            Console.ReadLine();
        }
        public string generateHashString(int index, int N, string hash_symbols)
        {
            char[] result = new char[N];
            for (int i = 0; i < N; i++)
            {
                result[N - 1 - i] = hash_symbols[(int)(index % hash_symbols.Length)];
                index /= hash_symbols.Length;
            }
            return new string(result);
        }
    }
}
