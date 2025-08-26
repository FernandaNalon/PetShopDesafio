using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopDesafio
{
    class Animal
    {
        // Encapsulamento: privados
        private string nome;
        private int idade;

        public Animal(string n, int i)
        {
            SetNome(n);
            SetIdade(i);
        }

        // Get/Set simples (sem propriedades)
        public void SetNome(string n)
        {
            if (n == null || n.Trim() == "")
                nome = "SemNome";
            else
                nome = n.Trim();
        }

        public string GetNome()
        {
            return nome;
        }

        public void SetIdade(int i)
        {
            if (i < 0) i = 0;
            idade = i;
        }

        public int GetIdade()
        {
            return idade;
        }

        // Polimorfismo: método que as filhas podem mudar
        public virtual void Atender()
        {
            Console.WriteLine($"{nome} está sendo atendido no banho padrão.");
        }
    }
}
