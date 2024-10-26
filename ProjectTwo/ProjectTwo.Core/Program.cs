using ProjectTwo.Core.Components;
using System;

namespace ProjectTwo.Core
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var hg = new HashGenerator();
            string hash = hg.generateHash(3);
            var mainer = new Mainer();
            mainer.Launch(3, hash);
            Console.ReadLine();
        }
    }
}
