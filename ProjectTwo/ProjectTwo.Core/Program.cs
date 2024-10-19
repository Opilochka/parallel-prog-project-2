using ProjectTwo.Core.Components;
using System;

namespace ProjectTwo.Core
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var hg = new HashGenerator();
            hg.Create(10);
        }
    }
}
