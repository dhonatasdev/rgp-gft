using System;
using gft.src.Entities;

namespace gft
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight Arus = new Knight("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jennica", 23, "White Wizard");
            Console.WriteLine(Arus.Attack());
            Console.WriteLine(wizard.Attack(7));
        }
    }
}
