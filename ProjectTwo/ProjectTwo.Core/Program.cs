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
            string hash = hg.generateHash(3);
            var mainer = new Mainer();
            mainer.Launch(3, hash);
            Console.ReadLine();
        }
    }
}
