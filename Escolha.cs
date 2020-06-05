namespace Projeto_TesteUm_Calculadoras
{
    public class Escolha
    {
        public string decisao;

        public void Selecionar(){
            switch (decisao)
            {
                
                case "1":

                System.Console.WriteLine("Aproveite o jogo com o mago Bens Rousherr");
                break;

                case "2":

                System.Console.WriteLine("Aproveite o jogo com a engenheira Ciler Vesth");
                break;

                case "3":

                System.Console.WriteLine("Aproveite o jogo com o mutante Ralph The Boy");
                break;

                case "mago":

                System.Console.WriteLine("Aproveite o jogo com o mago Bens Rousherr");
                break;

                case "engenheira":

                System.Console.WriteLine("Aproveite o jogo com a engenheira Ciler Vesth");
                break;

                case "mutante":

                System.Console.WriteLine("Aproveite o jogo com o mutante Ralph The Boy");
                break;

                case "Bens Rousher":

                System.Console.WriteLine("Aproveite o jogo com o mago Bens Rousherr");
                break;

                case "Ciler Vesth":

                System.Console.WriteLine("Aproveite o jogo com a engenheira Ciler Vesth");
                break;

                case "Ralph the boy":

                System.Console.WriteLine("Aproveite o jogo com o mutante Ralph The Boy");
                break;

                case "Bens":

                System.Console.WriteLine("Aproveite o jogo com o mago Bens Rousherr");
                break;

                case "Ciler":

                System.Console.WriteLine("Aproveite o jogo com a engenheira Ciler Vesth");
                break;

                case "Ralph":

                System.Console.WriteLine("Aproveite o jogo com o mutante Ralph The Boy");
                break;

                case null:

                System.Console.WriteLine("Selecione um player!");
                break;

                case " ":

                System.Console.WriteLine("Selecione um player!");
                break;

                case "  ":

                System.Console.WriteLine("Selecione um player!");
                break;

            }
        }  
    }
}