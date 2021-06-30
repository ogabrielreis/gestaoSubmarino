using System;
using Sub;
using Mis;
using User;
using Pat;
using Dorm;
using It;
using Prob;
using Manut;



namespace GestaoSubmarino
{
    class Program
    {
        static void Main(string[] args)
        {
            int item, idSubmarino, idMissao, idUsuario, idPatente, idDormitorio,
            qtdLivreDormitorio, qtdTotalDormitorio, idItem, qtdItem, vidaUtilItem,
            idadeItem, idProblema, tempoConserto, idManutencao, tempoEstimadoManutencao,
            pesquisaItem,  d, m, a;
            
            char dado, cont;

            bool continuar = false;

            string nomeSubmarino, missaoSubmarino, localMissao, tempoMissao, nomeUsuario,
            emailUsuario, passwordUsuario, nomePatente, nomeItem, itemProblema, causaProblema,
            efeitoProblema, itemManutencao;

            
            Submarino sub = new Submarino();
            Missao mis = new Missao();
            Usuario user = new Usuario();
            Patente pat = new Patente();
            Dormitorio dorm = new Dormitorio();
            Item it = new Item();
            Problema prob = new Problema();
            Manutencao manut = new Manutencao();

            do {
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
                    Console.Write("Qual o id da patente? ");
                    idPatente = Convert.ToInt32(Console.ReadLine());
                    pat.setIdPatente(idPatente);

                    Console.Write("Qual o nome da patente? ");
                    nomePatente = Convert.ToString(Console.ReadLine());
                    pat.setNomePatente(nomePatente);
                }

                else if (item == 5) {
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
                    Console.Write("Qual o id do problema? ");
                    idProblema = Convert.ToInt32(Console.ReadLine());
                    prob.setIdProblema(idProblema);

                    Console.Write("Qual o item que está com problema? ");
                    itemProblema = Convert.ToString(Console.ReadLine());
                    prob.setItemProblema(itemProblema);

                    Console.Write("Qual o tempo para conserto (em dias)? ");
                    tempoConserto = Convert.ToInt32(Console.ReadLine());
                    prob.setTempoConserto(tempoConserto);

                    Console.Write("Qual a causa do problema? ");
                    causaProblema = Convert.ToString(Console.ReadLine());
                    prob.setCausaProblema(causaProblema);

                    Console.Write("Qual o efeito do problema? ");
                    efeitoProblema = Convert.ToString(Console.ReadLine());
                    prob.setEfeitoProblema(efeitoProblema);
                }

                else if (item == 8) {
                    Console.Write("Qual o id da manutenção? ");
                    idManutencao = Convert.ToInt32(Console.ReadLine());
                    manut.setIdManutencao(idManutencao);

                    Console.Write("Qual o item da manutenção? ");
                    itemManutencao = Convert.ToString(Console.ReadLine());
                    manut.setItemManutencao(itemManutencao);

                    Console.Write("Qual o tempos estimado para fazer a manutenção (em dias)? ");
                    tempoEstimadoManutencao = Convert.ToInt32(Console.ReadLine());
                    manut.setTempoEstimadoManutencao(tempoEstimadoManutencao);
                }
                else {
                    Console.WriteLine("Item não encontrado!");
                }
            }

            else if (dado == 'p') {
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
                    Console.WriteLine("Qual o id do submarino deseja pesquisar? ");
                    pesquisaItem = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("O id é " + sub.getIdSubmarino());
                    Console.WriteLine("O nome é " + sub.getNomeSubmarino());      
                    Console.WriteLine("A missão atual é " + sub.getMissaoSubmarino());
                    Console.WriteLine("A data da missão é " + sub.getDataUltimaMissao());
                }

                else if (item == 2) {
                    Console.WriteLine("Qual o id da missão que deseja pesquisar? ");
                    pesquisaItem = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("O id da missão é " + mis.getIdMissao());
                    Console.WriteLine("O Local da missão é " + mis.getLocalMissao());
                    Console.WriteLine("O tempo da missão é " + mis.getTempoMissao());
                    Console.WriteLine("A data da expedição é " + mis.getDataExpedicao());
                }

                else if (item == 3) {
                    Console.WriteLine("Qual o id do usuário que deseja pesquisar? ");
                    pesquisaItem = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("O id do usuário é " + user.getIdUsuario());
                    Console.WriteLine("O nome do usuário é " + user.getNomeUsuario());
                    Console.WriteLine("O Email do usuário é " + user.getEmailUsuario());
                }

                else if (item == 4) {
                    Console.WriteLine("Qual o id da patente que deseja pesquisar? ");
                    pesquisaItem = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("O id da patente é " + pat.getIdPatente());
                    Console.WriteLine("O nome da patente é " + pat.getNomePatente());
                }

                else if (item == 5) {
                    Console.WriteLine("Qual o id do dormitório que deseja pesquisar? ");
                    pesquisaItem = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("O id do dormitório é " + dorm.getIdDormitorio());
                    Console.WriteLine("A quantidade total de dormitórios é " + dorm.getQtdTotalDormitorio());
                    Console.WriteLine("A quantidade livre de dormitórios é " + dorm.getQtdLivreDormitorio());
                }

                else if (item == 6) {
                    Console.WriteLine("Qual o id do item que deseja pesquisar? ");
                    pesquisaItem = Convert.ToInt32(Console.ReadLine());
                    
                    Console.WriteLine("O id do item é " + it.getIdItem());
                    Console.WriteLine("O nome do item é " + it.getNomeItem());
                    Console.WriteLine("A quantidade disponível deste item é " + it.getQtdItem());
                    Console.WriteLine("A vida útil deste item é " + it.getVidaUtilItem());
                    Console.WriteLine("A idade deste item é " + it.getIdadeItem());
                }

                else if (item == 7) {
                    Console.WriteLine("Qual o id do problema que deseja pesquisar? ");
                    pesquisaItem = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("O id do problema é " + prob.getIdProblema());
                    Console.WriteLine("O item que apresenta problema é " + prob.getItemProblema());
                    Console.WriteLine("O tempo de conserto é " + prob.getTempoConserto());
                    Console.WriteLine("A causa do problema é " + prob.getCausaProblema());
                    Console.WriteLine("O efeito do problema é " + prob.getEfeitoProblema());
                }

                else if (item == 8) {
                    Console.WriteLine("Qual o id da manutenção que deseja pesquisar? ");
                    pesquisaItem = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("O id da manutenção é " + manut.getIdManutencao());
                    Console.WriteLine("o item em manutenção é " + manut.getItemManutecao());
                    Console.WriteLine("O tempo estimado da manutenção é de " + manut.getTempoEstimadoManutencao());
                }

                else {
                    Console.WriteLine("Item não encontrado!");
                }
            }

            Console.WriteLine("Deseja continuar? (s para sim e n para não) ");
            cont = Convert.ToChar(Console.ReadLine());

            if (cont == 's') {
                continuar = true;
            }
            else {
                continuar = false;
            }

            } while(continuar == true);
        }
    }
}
