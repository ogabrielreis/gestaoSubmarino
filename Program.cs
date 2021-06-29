using System;
using Submarino;
using Missao;
using Usuario;
using Item;



namespace GestaoSubmarino
{
    class Program
    {
        static void Main(string[] args)
        {
            int item, idSubmarino, d, m, a;
            char dado;
            string nomeSubmarino, missaoSubmarino;

            Console.WriteLine("Olá!");
            Console.WriteLine("Gostaria de pesquisar ou salvar os dados? (p ou s)");
            dado = Convert.ToChar(Console.ReadLine());

            if (dado == 's') {
                Console.WriteLine("O que tu gostaria de salvar?");
                Console.WriteLine("Tabela de itens:");
                Console.WriteLine("1 - Submarino");
                Console.WriteLine("2 - Missoes");
                Console.WriteLine("3 - Usuarios");
                Console.WriteLine("4 - Patentes");
                Console.WriteLine("5 - Dormitorio");
                Console.WriteLine("6 - Item");
                Console.WriteLine("7 - Problema");
                Console.WriteLine("8 - Manutenção");
                item = Convert.ToInt32(Console.ReadLine());

                if (item == 1) {
                    var sub = new Submarino();
                    
                    Console.Write("Qual o Id do Submarino? ");
                    idSubmarino = Convert.ToInt32(Console.ReadLine());
                    Submarino.IdSubmarino(idSubmarino);

                    Console.Write("Qual o nome do Submarino? ");
                    nomeSubmarino = Convert.ToString(Console.ReadLine());
                    Submarino.NomeSubmarino(nomeSubmarino);

                    Console.Write("Qual a missão atual do Submarino? ");
                    missaoSubmarino = Convert.ToString(Console.ReadLine());
                    Submarino.MissaoSubmarino(missaoSubmarino);

                    Console.Write("Qual o dia da última missão? ");
                    d = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Qual o mês da última missão? ");
                    m = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Qual o ano da última missão? ");
                    a = Convert.ToInt16(Console.ReadLine());   
                }

                else if(item == 2) {
                    var mis = new Missao();
                    
                    
                }
            }


        }
    }
}
