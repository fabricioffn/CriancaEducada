using System;

namespace CriancaEducada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Me diga o que você pensa sobre o aluno que não faz a lição de casa: Eu acho que é um bobo, e que vai ficar boboca pra sempre.");
            Console.WriteLine("");
            
            Console.WriteLine("uma criança educada diria: Me diga o que você pensa sobre o aluno que não faz a lição de casa: Eu acho que é um bobo, e que vai ficar boboca pra sempre.".Replace("bobo" , "@#$%" ).Replace("boboca" , "!@#$"));
        }
    }
}
