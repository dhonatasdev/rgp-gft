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
            Ninja wedge = new Ninja("Wedge", 23, "Ninja");
            BlackWizard topapa = new BlackWizard("Topapa", 23, "BlackWizard");
            Console.WriteLine(Arus.Attack());
            Console.WriteLine(wizard.Attack(7));
            Console.WriteLine(wedge.Attack(2));
            Console.WriteLine(topapa.Attack(10));
            
        }
    }
}
