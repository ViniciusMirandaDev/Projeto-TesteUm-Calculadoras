using System;

namespace Projeto_TesteUm_Calculadoras
{
    class Program
    {
        static void Main(string[] args)
        {
            Bens bens = new Bens();
            Ciler ciler = new Ciler();
            Ralph ralph = new Ralph();
            System.Console.WriteLine("Escolha seu player: ");
            System.Console.WriteLine();

            System.Console.WriteLine(bens.Calcular("Bens","Rousherr", "mago","O"));
            System.Console.WriteLine();
            System.Console.WriteLine(bens.CalcularVida(400));
            System.Console.WriteLine(bens.Calcular(30));
            System.Console.WriteLine(bens.CalcularDefesa(40));
            bens.Olhar();

            System.Console.WriteLine();

            System.Console.WriteLine(bens.Calcular("Ciler","Vesth", "engenheira","A"));
            System.Console.WriteLine();
            System.Console.WriteLine(bens.CalcularVida(500));
            System.Console.WriteLine(bens.Calcular(40));
            System.Console.WriteLine(bens.CalcularDefesa(30));
            ciler.Pular();

            System.Console.WriteLine();

            System.Console.WriteLine(bens.Calcular("Ralph","The Boy", "mutante","O"));
            System.Console.WriteLine();
            System.Console.WriteLine(bens.CalcularVida(300));
            System.Console.WriteLine(bens.Calcular(50));
            System.Console.WriteLine(bens.CalcularDefesa(70));
            ralph.Voar();

            System.Console.WriteLine();
            Escolha escolha = new Escolha();
            System.Console.WriteLine("------------------------------------ A Escolha ------------------------------------");
            System.Console.WriteLine("Digite o número do personagem, ou seu nome ou sua especificação para selecioná-lo: ");
            
            escolha.decisao=Console.ReadLine();
            escolha.Selecionar();
            
            
            
            
            
            

        }
    }
}
