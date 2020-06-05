namespace Projeto_TesteUm_Calculadoras
{
    public class Player
    {
        public virtual void Pular(){
            System.Console.WriteLine("O personagem está pulando normalmente");

        }
        public virtual void Voar(){
            System.Console.WriteLine("O personagem está voando normalmente");
        }
        public virtual void Olhar(){
            System.Console.WriteLine("O personagem está olhando normalmente");
        }
    }
}