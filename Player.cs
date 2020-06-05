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
        public string Calcular(string nome, string sobrenome, string especial, string genero){
            return $"-{genero} {especial} {nome} {sobrenome} com os caracterísitcas:";
        }
        public string Calcular(int ataque){
            return $"Ataque: {ataque}Pkd ";
        }
        public string CalcularDefesa(int defesa){
            return $"Defesa: {defesa}Pkd";
        }
        public string CalcularVida(int vida){
            return $"Vida:  {vida}Pkd";
        }
    }
}