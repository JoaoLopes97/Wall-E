using System;

namespace Wall_E
{
    public class Program
    {
        static void Main(string[] args)
        {
            Jogo jogo = new();
            Console.WriteLine(jogo.Jogar());
        }
    }
}
