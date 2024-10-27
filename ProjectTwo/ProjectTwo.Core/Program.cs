using ProjectTwo.Core.Components;
using System;

namespace ProjectTwo.Core
{
    internal class Program
    {
        /// <summary>
        /// Точка входа
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {
            var hg = new HashGenerator();
            string hash = hg.generateHash(7);
            var mainer = new Mainer();
            int[] threads = new int[] { 1, 2, 4, 8, 16 };
            mainer.Launch(7, hash, threads);
            Console.ReadLine();
        }
    }
}
