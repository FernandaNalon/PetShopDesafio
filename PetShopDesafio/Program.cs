using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShopDesafio;
class Program
{
    static void Main(string[] args)
    {
        // Array simples (sem List)
        Animal[] animais = new Animal[20];
        int quantidade = 0;

        int opcao = -1;

        while (opcao != 0)
        {
            Console.WriteLine("=== PETSHOP ===");
            Console.WriteLine("1 - Cadastrar animal");
            Console.WriteLine("2 - Listar animais");
            Console.WriteLine("3 - Atender animal");
            Console.WriteLine("0 - Sair");
            Console.Write("Digite a opção desejada: ");
            string entrada = Console.ReadLine();

            if (entrada == null)
            {
                entrada = "-1";
            }
            opcao = Convert.ToInt32(entrada);

            switch (opcao)
            {
                case 1:
                    if (quantidade >= animais.Length)
                    {
                        Console.WriteLine("Capacidade cheia.");
                        break;
                    }

                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();

                    Console.Write("Idade (número inteiro): ");
                    int idade = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Espécie (1-Cachorro, 2-Gato): ");
                    int especie = Convert.ToInt32(Console.ReadLine());

                    if (especie == 1)
                        animais[quantidade++] = new Cachorro(nome, idade);
                    else if (especie == 2)
                        animais[quantidade++] = new Gato(nome, idade);
                    else
                        Console.WriteLine("Espécie inválida.");
                    Console.Clear();
                    break;

                case 2:
                    if (quantidade == 0)
                    {
                        Console.WriteLine("Nenhum animal cadastrado.");
                    }
                    else
                    {
                        for (int i = 0; i < quantidade; i++)
                        {
                            // Tipo em tempo de execução (mostra a herança)
                            string tipo = animais[i].GetType().Name;
                            Console.WriteLine($"{i+1} - {tipo} | Nome: {animais[i].GetNome()} | Idade: {animais[i].GetIdade()}");
                        }
                    }
                    
                    break;

                case 3:
                    if (quantidade == 0)
                    {
                        Console.WriteLine("Nenhum animal para atender.");
                        break;
                    }

                    Console.Write("Índice do animal: ");
                    int idx = Convert.ToInt32(Console.ReadLine());
                    int idx_att = idx - 1;

                    if (idx_att >= 0 && idx_att < quantidade)
                    {
                        // Polimorfismo: chama o método da classe correta (Cachorro/Gato)
                        animais[idx_att].Atender();
                    }
                    else
                    {
                        Console.WriteLine("Índice inválido.");
                    }
                    
                    break;

                case 0:
                    Console.WriteLine("Encerrando...");
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}
