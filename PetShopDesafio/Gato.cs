using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopDesafio
{
    class Gato : Animal
    {
        public Gato(string n, int i) : base(n, i) { }

        public override void Atender()
        {
            Console.WriteLine($"[Gato] {GetNome()} miou baixinho. Banho rápido e toalha para acalmar.");
        }
    }
}
