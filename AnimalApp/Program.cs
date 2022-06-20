using System;

namespace AnimalApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programa de registro de pessoas e priorização de atendimento V.1
            Random randNumber = new Random();

            Console.WriteLine("PET ANIMAL");
            Console.WriteLine("Crie o registro do seu Pet, para ter um melhor atendimento!");
            Console.Write("Deseja realizar o Cadastro? Y/N ");
            char choice = char.Parse(Console.ReadLine());
            Console.Clear();

            if(choice == 'Y' || choice == 'y')
            {
                Console.WriteLine("Seja bem vindo ao sistema de cadastro do PET ANIMAL");
                Console.WriteLine();
                Console.WriteLine("Pedimos que preencha os dados solicitados para prosseguirmos com o atendimento");
                Console.WriteLine();
                Console.Write("Dados do Dono do Animal: ");
                string Nome = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Data de Nascimento: ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Estado de Nascimento: (Apenas Abreviação)");
                string STD =Console.ReadLine();
                

            }
            else if(choice == 'N' || choice == 'n')
            {
                Console.WriteLine("Certo, iremos criar gerar um número e essa será a sua senha..");
                int password = randNumber.Next();
                Console.WriteLine("Sua senha de atendimento é: "  +  password);
            }
            else
            {
                Console.WriteLine("Fora de escopo!");
            }
        }
    }
}
