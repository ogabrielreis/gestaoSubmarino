using System;
using Sub;
using Mis;
using User;
using Pat;
using Dorm;
using It;



namespace GestaoSubmarino
{
    class Program
    {
        static void Main(string[] args)
        {
            int item, idSubmarino, idMissao, idUsuario, idPatente, idDormitorio,
            qtdLivreDormitorio, qtdTotalDormitorio, idItem, qtdItem, vidaUtilItem,
            idadeItem, d, m, a;
            
            char dado;

            string nomeSubmarino, missaoSubmarino, localMissao, tempoMissao, nomeUsuario,
            emailUsuario, passwordUsuario, nomePatente, nomeItem;

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
                    Submarino sub = new Submarino();
                    
                    Console.Write("Qual o Id do Submarino? ");
                    idSubmarino = Convert.ToInt32(Console.ReadLine());
                    sub.setIdSubmarino(idSubmarino);

                    Console.Write("Qual o nome do Submarino? ");
                    nomeSubmarino = Convert.ToString(Console.ReadLine());
                    sub.setNomeSubmarino(nomeSubmarino);

                    Console.Write("Qual a missão atual do Submarino? ");
                    missaoSubmarino = Convert.ToString(Console.ReadLine());
                    sub.setMissaoSubmarino(missaoSubmarino);

                    Console.Write("Qual o dia da última missão? ");
                    d = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Qual o mês da última missão? ");
                    m = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Qual o ano da última missão? ");
                    a = Convert.ToInt16(Console.ReadLine());
                    sub.setDataUltimaMissao(d, m, a);


                }

                else if(item == 2) {
                    Missao mis = new Missao();

                    Console.Write("Qual o id da missão? ");
                    idMissao = Convert.ToInt32(Console.ReadLine());
                    mis.setIdMissao(idMissao);
                    
                    Console.Write("Qual o local da missão? ");
                    localMissao = Convert.ToString(Console.ReadLine());
                    mis.setLocalMissao(localMissao);

                    Console.Write("Qual o tempo da missão? ");
                    tempoMissao = Convert.ToString(Console.ReadLine());
                    mis.setTempoMissao(tempoMissao);

                    Console.Write("Qual o dia da missão? ");
                    d = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Qual o mês da missão? ");
                    m = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Qual o ano da missão? ");
                    a = Convert.ToInt16(Console.ReadLine());
                    mis.setDataExpedicao(d, m, a);                    
                }

                else if (item == 3) {
                    Usuario user = new Usuario();

                    Console.Write("Qual o id do usuário? ");
                    idUsuario = Convert.ToInt32(Console.ReadLine());
                    user.setIdUsuario(idUsuario);

                    Console.Write("Qual o nome do usuário? ");
                    nomeUsuario = Convert.ToString(Console.ReadLine());
                    user.setNomePatente(nomeUsuario);

                    Console.Write("Qual o E-mail do usuário? ");
                    emailUsuario = Convert.ToString(Console.ReadLine());
                    user.setEmailUsuario(emailUsuario);

                    Console.Write("Qual a senha do usuário? ");
                    passwordUsuario = Convert.ToString(Console.ReadLine());
                    user.setPasswordUsuario(passwordUsuario);
                }

                else if (item == 4) {
                    Patente pat = new Patente();

                    Console.Write("Qual o id da patente? ");
                    idPatente = Convert.ToInt32(Console.ReadLine());
                    pat.setIdPatente(idPatente);

                    Console.Write("Qual o nome da patente? ");
                    nomePatente = Convert.ToString(Console.ReadLine());
                    pat.setNomePatente(nomePatente);
                }

                else if (item == 5) {
                    Dormitorio dorm = new Dormitorio();

                    Console.Write("Qual o id do dormitório? ");
                    idDormitorio = Convert.ToInt32(Console.ReadLine());
                    dorm.setIdDormitorio(idDormitorio);

                    Console.Write("Qual a quantidade total de dormitórios? ");
                    qtdTotalDormitorio = Convert.ToInt32(Console.ReadLine());
                    dorm.setQtdTotalDormitorio(qtdTotalDormitorio);

                    Console.Write("Qual a quantidade livre de dormitórios? ");
                    qtdLivreDormitorio = Convert.ToInt32(Console.ReadLine());
                    dorm.setQtdLivreDormitorio(qtdLivreDormitorio);
                }

                else if (item == 6) {
                    Item it = new Item();

                    Console.Write("Qual o id do item? ");
                    idItem = Convert.ToInt32(Console.ReadLine());
                    it.setIdItem(idItem);

                    Console.Write("Qual o nome do item? ");
                    nomeItem = Convert.ToString(Console.ReadLine());
                    it.setNomeItem(nomeItem);

                    Console.Write("Qual a quantidade deste item? ");
                    qtdItem = Convert.ToInt32(Console.ReadLine());
                    it.setQtdItem(qtdItem);

                    Console.Write("Qual a vida útil do item (em anos)? ");
                    vidaUtilItem = Convert.ToInt32(Console.ReadLine());
                    it.setVidaUtilItem(vidaUtilItem);

                    Console.Write("Qual a idade do item (em anos)? ");
                    idadeItem = Convert.ToInt32(Console.ReadLine());
                    it.setIdadeItem(idadeItem);
                }

                else if (item == 7) {

                }

                else if (item == 8) {

                }
                else {
                    Console.WriteLine("Item não encontrado!");
                }
            }
        }
    }
}
