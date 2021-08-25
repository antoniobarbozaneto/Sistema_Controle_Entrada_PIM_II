using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sistema_Controle_Entrada_PIM
{
    class Program
    {
        public struct Convidado //struct convidado
        {
            public string nome;
            public string email;
            public int num_a;
            public string tipo;
            public DateTime data;
        }

        static void Main(string[] args)
        {

            int[] lista = new int[200];

            Convidado[] convidados = new Convidado[200];

            int j = 0;
            int i = 0;
            int aux = 0;     //contador de assentos para Convidados do palestrante e para os professor, as duas primeiras filas 20 assentos reservados.
            int aux2 = 20;   //contador de assentos para pessoas COM deficiencia Fisica.
            int aux3 = 30;   //contador de assentos para pessoas SEM deficiencia Fisica.
            int total = 200; //total de assentos 
            int contAssento_Pcd = 0, contAssento_Spcd = 0;
            bool sorteio = false;
            bool tecla_e1 = false;
            bool tecla_e2 = false;
            string resp;

            for (i = 0; i < total && j == 0; i++)
            {
                Console.WriteLine("------------------------------ [ PAINEL ASSENTOS ] -------------------------------------------------");
                Console.WriteLine("\n [STATUS] - Quantidade de pessoas cadastradas: " + i + " / " + total);
                Console.WriteLine("\n Quantidade de Assentos Ocupados (Professores / Convidados do Palestrante) : [" + aux + " / 20] Assentos");
                Console.WriteLine(" Quantidade de Assentos Ocupados (Pessoas Com Deficiência Fisica) : [" + contAssento_Pcd + " / 10] Assentos");
                Console.WriteLine(" Quantidade de Assentos Ocupados (Pessoas Sem Deficiência Fisica : [" + contAssento_Spcd + " / 170] Assentos");
                Console.WriteLine("----------------------------------------------------------------------------------------------------");
                //
                Console.WriteLine();
                //
                Console.WriteLine("----------------------------- [ MENU DE CADASTROS ] ------------------------------------------------");
                Console.WriteLine(" 1) - Para Cadastrar Professor: Aperte [1]");//1
                Console.WriteLine(" 2) - Para Cadastrar Convidado do Palestrante: Aperte [2]");//2
                Console.WriteLine(" 3) - Para Cadastrar Convidado com Deficiência Fisica: Aperte [3]");//3
                Console.WriteLine(" 4) - Para Cadastrar Convidado sem Deficiência Fisica: Aperte [4]");//4
                Console.WriteLine("\n 5)- Para encerrar os cadastros e iniciar a palestra: Aperte [5]");//5
                Console.WriteLine("----------------------------------------------------------------------------------------------------");
                Console.Write("\n Digite a opção desejada: ");
                resp = Console.ReadLine();

                if (resp == "1")
                {
                    if (aux < 20) //Duas primeiras filas reservadas para os professores e convidados do palestrantes.
                    {
                        aux++;
                        //Console.WriteLine("Entrei aqui 1");
                        //Cadastrar o professor
                        Console.WriteLine("\n [Cadastrando Professor]");
                        Console.Write("Informe seu nome: ");
                        convidados[aux - 1].nome = Console.ReadLine();
                        Console.Write("Informe seu email: ");
                        convidados[aux - 1].email = Console.ReadLine();
                        convidados[aux - 1].tipo = "[ Professor ]";
                        convidados[aux - 1].num_a = aux;
                        DateTime horario = DateTime.Now;
                        convidados[aux - 1].data = horario;
                        //[aux-1] para começar guardando na posição 0 do array, o assento recebe (aux) para o assento ser o numero 1 e não 0.

                        Console.WriteLine("\n ( Convidado Cadastrado com sucesso!!! )");

                        //Mostra o Ticket
                        Console.WriteLine("\n----------------[TICKET]-----------------");
                        Console.WriteLine("NOME: " + convidados[aux - 1].nome + "");
                        Console.WriteLine("E-mail: " + convidados[aux - 1].email + "");
                        Console.WriteLine("Número do Assento: [" + convidados[aux - 1].num_a + "]");
                        Console.WriteLine("Categoria: " + convidados[aux - 1].tipo);
                        Console.WriteLine("Horário: " + convidados[aux - 1].data);
                        Console.WriteLine("-----------------------------------------");
                        Thread.Sleep(2500);
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("\n Todos os assentos reservados das duas primeiras filas para professores e convidados do palestrantes já estão ocupados!");
                        Console.WriteLine("\n Aguarde um momento e tente novamente...");
                        Thread.Sleep(2000);
                        Console.Clear();
                        i--;
                    }
                }
                else if (resp == "2")
                {
                    if (aux < 20) //Duas primeiras filas reservadas para os professores e convidados do palestrantes.
                    {
                        aux++;
                        //Console.WriteLine("Entrei aqui 2");
                        //Cadastrar o Convidado do Palestrante
                        Console.WriteLine("\n [ Cadastrando convidado do palestrante ]");
                        Console.Write("Informe seu nome: ");
                        convidados[aux - 1].nome = Console.ReadLine();
                        Console.Write("Informe seu email: ");
                        convidados[aux - 1].email = Console.ReadLine();
                        convidados[aux - 1].tipo = "[Convidado do Palestrante]";
                        convidados[aux - 1].num_a = aux;
                        DateTime horario = DateTime.Now;
                        convidados[aux - 1].data = horario;

                        Console.WriteLine("\n ( Convidado Cadastrado com sucesso!!! )");

                        Console.WriteLine();

                        //Mostra o Ticket
                        Console.WriteLine("\n----------------[TICKET]-----------------");
                        Console.WriteLine("NOME: " + convidados[aux - 1].nome + "");
                        Console.WriteLine("E-mail: " + convidados[aux - 1].email + "");
                        Console.WriteLine("Número do Assento: [" + convidados[aux - 1].num_a + "]");
                        Console.WriteLine("Categoria: " + convidados[aux - 1].tipo);
                        Console.WriteLine("Horário: " + convidados[aux - 1].data);
                        Console.WriteLine("-----------------------------------------");

                        Thread.Sleep(2500);
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("\n Todos os assentos reservados das duas primeiras filas para professores e convidados do palestrantes já estão ocupados!");
                        Console.WriteLine("\n Aguarde um momento e tente novamente...");
                        Thread.Sleep(2000);
                        Console.Clear();
                        i--;
                    }
                }
                else if (resp == "3")
                {
                    if (aux2 < 30) //5% do total de assentos reservados para as pessoas com deficiencia fisica.
                    {
                        aux2++;
                        //Console.WriteLine("Entrei aqui 3");
                        //Cadastrar o Convidado Com Deficiencia Fisica
                        Console.WriteLine("\n [Cadastrando pessoa COM Deficiência física]");
                        Console.Write("Informe seu nome: ");
                        convidados[aux2 - 1].nome = Console.ReadLine();
                        Console.Write("Informe seu email: ");
                        convidados[aux2 - 1].email = Console.ReadLine();
                        convidados[aux2 - 1].tipo = "[Pessoas COM Deficiência física]";
                        convidados[aux2 - 1].num_a = aux2;
                        DateTime horario = DateTime.Now;
                        convidados[aux2 - 1].data = horario;

                        Console.WriteLine("\n ( Convidado Cadastrado com sucesso!!! )");
                        contAssento_Pcd++;
                        Console.WriteLine();

                        //Mostra o Ticket
                        Console.WriteLine("\n----------------[TICKET]-----------------");
                        Console.WriteLine("NOME: " + convidados[aux2 - 1].nome + "");
                        Console.WriteLine("E-mail: " + convidados[aux2 - 1].email + "");
                        Console.WriteLine("Número do Assento: [" + convidados[aux2 - 1].num_a + "]");
                        Console.WriteLine("Categoria: " + convidados[aux2 - 1].tipo);
                        Console.WriteLine("Horário: " + convidados[aux2 - 1].data);
                        Console.WriteLine("-----------------------------------------");

                        Thread.Sleep(2500);
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Todos os assentos reservados para as pessoas COM deficiencia fisica já estão ocupados!");
                        Console.WriteLine("\n Aguarde um momento e tente novamente...");
                        Thread.Sleep(2000);
                        Console.Clear();
                        i--;
                    }
                }
                else if (resp == "4")
                {
                    if (aux3 < 200) //170 Lugares restantes para as pessoas normais. //como eu já começo no assento 30 e preciso cadastrar 170 pessoas, preciso fazer o laço ir até 200.

                    {
                        aux3++;
                        //Console.WriteLine("Entrei aqui 4");
                        //Cadastrar o Convidado SEM Deficiencia Fisica
                        Console.WriteLine("\n [Cadastrando pessoa SEM Deficiência física]");
                        Console.Write("Informe seu nome: ");
                        convidados[aux3 - 1].nome = Console.ReadLine();
                        Console.Write("Informe seu email: ");
                        convidados[aux3 - 1].email = Console.ReadLine();
                        convidados[aux3 - 1].tipo = "[Pessoas SEM Deficiência física]";
                        convidados[aux3 - 1].num_a = aux3;
                        DateTime horario = DateTime.Now;
                        convidados[aux3 - 1].data = horario;

                        Console.WriteLine("\n ( Convidado Cadastrado com sucesso!!! )");
                        contAssento_Spcd++;
                        Console.WriteLine();

                        //Mostra o Ticket
                        Console.WriteLine("\n----------------[TICKET]-----------------");
                        Console.WriteLine("NOME: " + convidados[aux3 - 1].nome + "");
                        Console.WriteLine("E-mail: " + convidados[aux3 - 1].email + "");
                        Console.WriteLine("Número do Assento: [" + convidados[aux3 - 1].num_a + "]");
                        Console.WriteLine("Categoria: " + convidados[aux3 - 1].tipo);
                        Console.WriteLine("Horário: " + convidados[aux3 - 1].data);
                        Console.WriteLine("-----------------------------------------");

                        Thread.Sleep(2500);
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Todos os assentos reservados para pessoas SEM deficiência fisica já estão ocupados");
                        Console.WriteLine("\n Aguarde um momento e tente novamente...");
                        Thread.Sleep(2000);
                        Console.Clear();
                        i--;
                    }
                }
                else if (resp == "5")//Sair do laço.
                {
                    Console.WriteLine("\n Cadastros encerrados...");
                    //   Thread.Sleep(1000);
                    j = 1; //recebe 1 para sair do For.
                    i--;
                }
                else
                {
                    Console.WriteLine("\n Opção Inválida!");
                    Console.WriteLine("\n Aguarde instantes e tente novamente...");
                    Thread.Sleep(2000);
                    Console.Clear();
                    i--;
                }
            }
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
            //////////Após sair do laço depois de preencher todos os 200 lugares.
            Console.WriteLine(" A Palestra irá começar!");
            Console.WriteLine("     Aguarde um minuto...");
            Thread.Sleep(2000);
            Console.Clear();

            /////////////////Segunda parte do programa (O Sorteio)
            ///            
            resp = "";
            while (tecla_e1 == false)
            {
                Console.WriteLine("------------------------------ [ PAINEL ASSENTOS ] -------------------------------------------------");
                Console.WriteLine("\n [STATUS] - Quantidade de pessoas cadastradas: " + i + " / " + total);
                Console.WriteLine("\n Quantidade de Assentos Ocupados (Professores / Convidados do Palestrante) : [" + aux + " / 20] Assentos");
                Console.WriteLine(" Quantidade de Assentos Ocupados (Pessoas Com Deficiência Fisica) : [" + contAssento_Pcd + " / 10] Assentos"); //5% assentos totais reservadis para PCD
                Console.WriteLine(" Quantidade de Assentos Ocupados (Pessoas Sem Deficiência Fisica : [" + contAssento_Spcd + " / 170] Assentos");
                Console.WriteLine("----------------------------------------------------------------------------------------------------");

                Console.WriteLine(" 1) - Para Realizar o sorteio: Aperte [1] ");
                Console.Write("\n Digite a opção desejada: ");
                resp = Console.ReadLine();

                if (resp == "1")
                {
                    tecla_e1 = true;
                    resp = "";

                    Random rnd = new Random();

                    Console.WriteLine();

                    while (sorteio == false)
                    {
                        Console.WriteLine(" Realizando sorteio...");
                        Thread.Sleep(1500);

                        int valorR = rnd.Next(0, total);

                        // Console.WriteLine(valorR);

                        if (convidados[valorR].nome != null && convidados[valorR].tipo != "[Convidado do Palestrante]")
                        {
                            Console.WriteLine("\n------[ PARABÉNS!!! " + convidados[valorR].nome + ", Você foi sorteado!]------");
                            Console.WriteLine("\n-----------[BILHETE PREMIADO]------------");
                            // Console.WriteLine(" O BILHETE SORTEADO FOI: [" + (valorR) + "]");
                            Console.WriteLine("\n----------------[TICKET]-----------------");
                            Console.WriteLine("NOME: " + convidados[valorR].nome + "");
                            Console.WriteLine("E-mail: " + convidados[valorR].email + "");
                            Console.WriteLine("Número do Assento: [" + convidados[valorR].num_a + "]");
                            Console.WriteLine("Categoria: " + convidados[valorR].tipo);
                            Console.WriteLine("Horário: " + convidados[valorR].data);
                            Console.WriteLine("-----------------------------------------");

                            tecla_e2 = false;
                            while (tecla_e2 == false)//laço2
                            {
                                Console.Write("\n Deseja fazer outro sorteio? (S/N): ");
                                resp = Console.ReadLine();

                                if (resp == "S" || resp == "s")
                                {
                                    Thread.Sleep(1000);
                                    Console.Clear();
                                    sorteio = false;
                                    tecla_e2 = true;//sai do laço2 
                                }
                                else if ((resp == "N" || resp == "n"))
                                {
                                    sorteio = true;
                                    tecla_e2 = true;//sai do laço2
                                }
                                else
                                {
                                    tecla_e2 = false;//matém no laço até a resposta ser Sim ou Não.
                                    Console.WriteLine("\n Opção Inválida!");
                                    Console.WriteLine("\n Para realizar outro sorteio aperte: [S] ou [s] / Para encerrar os sorteios aperte: [N] ou [n]");
                                    Thread.Sleep(2000);
                                    Console.Clear();
                                }
                            }
                        }
                    }
                }
                else
                {
                    tecla_e1 = false;
                    Console.WriteLine("\n Opção Inválida!");
                    Console.WriteLine("\n Aguarde instantes e tente novamente...");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
            }
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("\n Sorteios Finalizados com sucesso!!!");
            Console.WriteLine("\n MENSAGEM: Os sorteados receberam seus brindes ao término da palestra.");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine(" Aperte uma tecla para fechar o programa...");
            Console.ReadKey();
        }
    }
}
