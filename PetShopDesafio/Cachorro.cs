using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopDesafio
{
    class Cachorro : Animal
    {
        public Cachorro(string n, int i) : base(n, i) { }

        public override void Atender()
        {
            Console.WriteLine($"[Cachorro] {GetNome()} abanou o rabo. Banho com água morna e secagem rápida.");
        }
    }
}
