using System;

namespace ProjectTwo.Core.Components
{
    internal class Mainer
    {
        /// <summary>
        /// Запуск подбора хэша
        /// </summary>
        /// <param name="N">длина хэша</param>
        /// <param name="target_hash">заданный хэш для подбора</param>
        public void Launch(int N, string target_hash)
        {
            hashSelection(N, target_hash);
        }
        /// <summary>
        /// Функция подбора хэша
        /// </summary>
        /// <param name="N">длина хэша</param>
        /// <param name="target_hash">заданный хэш для подбора</param>
        public void hashSelection(int N, string target_hash)
        {
            string hash_symbols = "0123456789abcdef";
            int num_combinations = (int)Math.Pow(hash_symbols.Length, N);
            for (int i = 0; i < num_combinations; i++)
            {
                string tmp = generateHashString(i, N, hash_symbols);

                if (hashChecking(tmp, target_hash)) 
                {
                    Console.WriteLine($"Подбор завершен, результат: {tmp}");
                    break;
                }
            }
        }
        /// <summary>
        /// Генерация хэша заданной длины
        /// </summary>
        /// <param name="index">индекс для изменения символа при переборе</param>
        /// <param name="N">длина хэша</param>
        /// <param name="hash_symbols">16-ричный набор символов</param>
        /// <returns>строка хэша</returns>
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
        /// <summary>
        /// Сравнение хэшей
        /// </summary>
        /// <param name="maybe_str">подобранный хэш</param>
        /// <param name="target_hash">истинный хэш</param>
        /// <returns>результат сравнения</returns>
        public bool hashChecking(string maybe_str, string target_hash)
        {
            return maybe_str == target_hash;
        }
    }
}
