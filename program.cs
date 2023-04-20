
using System;
using System.Runtime.Intrinsics.X86;

public struct Bolo
{
    public string nome;
    public string ingredientes;

}

public struct ListTelefonica
{
    public string nome;
    public string telefone;

}
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("------");
        //->Desenvolve um programa console que mostre uma variavel do tipo inteiro.
        int inteiro = 1;
        Console.WriteLine("Numero inteiro é: " + inteiro);
        Console.WriteLine("------");

        // ->Desenvolva um programa console que mostre uma varivel do tipo long
        long nlong = 12345679;
        Console.WriteLine("Número Long é: " + nlong);
        Console.WriteLine("------");

        //->Desenvolva um programa console que mostre uma variavel do tipo float
        float nfloat = 17.17f;
        Console.WriteLine("Número Long é: " + nfloat);
        Console.WriteLine("------");

        // ->Desenvolva um programa console que mostre uma variavel do tipo double
        double ndouble = 123567d;
        Console.WriteLine("Número Long é: " + ndouble);
        Console.WriteLine("------");

        // ->Desenvolva um programa console que mostre uma variavel do tipo char
        char sexo = 'm';
        Console.WriteLine("Sexo: " + sexo);
        Console.WriteLine("------");

        // ->Desenvolva um programa console que mostreuma variavel do tipo string
        string str = " Renato é um programador inicio de carreira";
        Console.WriteLine(str);
        Console.WriteLine("------");

        //->Desenvolva um programa console que mostre uma variavel do tipo bool
        bool b = true;
        Console.WriteLine("O valor booleano é " + b);
        Console.WriteLine("------");

        //->Desenvolva um programa console que mostre uma variavel do tipo DateTime
        var data = DateTime.Now;

        Console.WriteLine("A data de hoje é : " + data.Day + "/" + data.Month + "/" + data.Year);
        Console.WriteLine("------");

        //->Desenvolva um programa console que some dois valores e retorne na tela o resultado
        int n1 = 1, n2 = 2;
        Console.WriteLine("A soma de n1 +n2 é " + (n1 + n2));
        Console.WriteLine("------");

        //->Desenvolve um programa console que receba um valor e verifique se ele é impar ou par
        float nParImpar = 0;
        Console.WriteLine("Entre com o numero: ");
        nParImpar = float.Parse(Console.ReadLine());

        if (nParImpar % 2 == 0)
        {
            Console.WriteLine("O número " + nParImpar + " é PAR! ");
            Console.WriteLine("------");
        }
        else
        {
            Console.WriteLine("O número " + nParImpar + " é IMPAR! ");
            Console.WriteLine("------");
        }

        // ->Desenvolva um programa console que receba a distancia percorrida e o tempo decorrido e retorne a velocidade media.
        Console.WriteLine("Entre com a distância percorrida: ");
        float distancacia = float.Parse(Console.ReadLine());

        Console.WriteLine("Entre com a velocidade percorrida: ");
        float velocidade = float.Parse(Console.ReadLine());

        Console.WriteLine("A velocidade média é D/V: " + distancacia / velocidade + " m/s");
        Console.WriteLine("------");

        //Desenvolva um programa console que receba dois valores inteiros e calcule a media.

        Console.WriteLine("Entre com a nota 1: ");
        float num1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Entre com a nota 2: ");
        float num2 = float.Parse(Console.ReadLine());

        Console.WriteLine("A média é: " + (num1 + num2) / 2);
        Console.WriteLine("------");

        //Desenvolva um programa console que receba o peso, altura e calcule o IMC

        Console.WriteLine("Entre Peso em KG Ex: 1.80 : ");
        float peso = float.Parse(Console.ReadLine());

        Console.WriteLine("Entre com a altura em kg Ex: 95.5 : ");
        float altura = float.Parse(Console.ReadLine());

        float calculoIMC = peso / (altura * altura);

        Console.WriteLine("Seu IMC é: " + calculoIMC);


        if (calculoIMC < 18.5f)
        {
            Console.WriteLine("CUIDADO: Seu peso está abaixo do Normal");
            Console.WriteLine("------");
        }
        if (calculoIMC > 18.5f && calculoIMC <= 24.9f)
        {
            Console.WriteLine("Seu peso é Normal");
            Console.WriteLine("------");
        }
        if (calculoIMC >= 25 && calculoIMC <= 29.9f)
        {
            Console.WriteLine("CUIDADO: Você está com excesso de Peso");
            Console.WriteLine("------");
        }
        if (calculoIMC >= 30 && calculoIMC <= 34.9f)
        {
            Console.WriteLine("CUIDADO: Obsidade classe 1");
            Console.WriteLine("------");
        }
        if (calculoIMC >= 35 && calculoIMC <= 39.9f)
        {
            Console.WriteLine("CUIDADO: Obsidade classe 2");
            Console.WriteLine("------");
        }
        if (calculoIMC > 40)
        {
            Console.WriteLine("CUIDADO: Obsidade classe 3");
            Console.WriteLine("------");
        }

        //->Desenvolva um programa console que receba um nome e retorne a contagem de caracteres que esse nome possui.

        Console.WriteLine("Entre com o nome: ");
        string nome = Console.ReadLine();
        Console.WriteLine("O nome: " + nome.ToUpper() + " tem: " + nome.ToString().Length);
        Console.WriteLine("------");

        // ->Desenvolva um programa que identifica se a data informada é seu aniversario

        var dataHj = DateTime.Now;

        Console.WriteLine("Entre com o DIA do seu Nascimento: ");
        int dia = int.Parse(Console.ReadLine());

        Console.WriteLine("Entre com o MÊS do seu Nascimento: ");
        int mes = int.Parse(Console.ReadLine());

        Console.WriteLine("Entre com o ANO do seu Nascimento: ");
        int ano = int.Parse(Console.ReadLine());

        if (dataHj.Day == dia && dataHj.Month == mes && dataHj.Year == ano)
        {
            Console.WriteLine("Hoje é ser aniversário, Parabens!");
            Console.WriteLine("------");
        }
        else
        {
            Console.WriteLine("Não é seu Aniversário");
            Console.WriteLine("------");
        }

        //->Desenvolva um programa que receba uma data e identifique qual o mes que foi informado naquela data.

        Console.WriteLine("Entre com o dia mes e ano ex: 01/01/1962");
        var dataHj2 = DateTime.Parse(Console.ReadLine());

        switch (dataHj2.Month)
        {
            case 01:
                Console.WriteLine("Mês de Janeiro");
                break;
            case 02:
                Console.WriteLine("Mês de Fevereiro");
                break;
            case 03:
                Console.WriteLine("Mês de Março");
                break;
            case 04:
                Console.WriteLine("Mês de Abril");
                break;
            case 05:
                Console.WriteLine("Mês de Maio");
                break;
            case 06:
                Console.WriteLine("Mês de Junho");
                break;
            case 07:
                Console.WriteLine("Mês de Juho");
                break;
            case 08:
                Console.WriteLine("Mês de Agosto");
                break;
            case 09:
                Console.WriteLine("Mês de Setembro");
                break;
            case 10:
                Console.WriteLine("Mês de Outubro");
                break;
            case 11:
                Console.WriteLine("Mês de Novembro");
                break;
            case 12:
                Console.WriteLine("Mês de Dezembro");
                break;
            default:
                Console.WriteLine("Você deve ter informado a data errada!");
                break;
        }

        //Desenvolva um programa que receba uma data e identifique qual o ano que foi informado naquela data.
        Console.WriteLine("Entre coma data 01/01/1962");
        var dataHj4 = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("O ano informado é: " + dataHj4.Year);

        //->Desenvolva um program que receba uma data e identifique qual o dia que foi informada naquela data
        Console.WriteLine("Entre coma data 01/01/1962");
        var dataHj5 = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("O dia informado é: " + dataHj5.Day);

        //Desenvolva um programa que retorne a data atual de hoje.
        var dataHjmsm = DateTime.Now;
        Console.WriteLine("O data de hoje é : " + dataHjmsm);

        //->Desenvolva um programa que receba um valor e verifique o quanto esse valor esta distante do valor 10.
        Console.WriteLine("Entre com o valor : " + dataHjmsm);
        int numero = int.Parse(Console.ReadLine());
        Console.WriteLine("A distância é de : " + (numero - 10));

        //->Dado os valores 4,5 e 8 construa um programa que calcule a media harmonica.

        float m = (1 / 4) + (1 / 5) + (1 / 8);
        float mediaharm = 0f;
        mediaharm = 3 / m;
        Console.WriteLine("A média harmônicia de 4, 5 e 8 é : " + mediaharm);

        /* ->Aurelio é apaixonado por cozinha e adora pesquisar receitas, construa um programa que simule um livro de receitas para aurelio, o programa ira receber qual a categoria de receitas que ele vai pesquisar e retornar quais são as receitas.

             Exemplo=> Bolo
                 {
                     ChesseCake
                     Bolo de fuba
                     Bolo de cenoura
                     }
        */

        // Fazer uma struct de receitas:
        // Nome da receita receita e seus ingredientes
        // cadastrar, remover, alterar
        // olhar no começo do codigo, a estruct está lá


        Console.WriteLine("PROGRAMA DE CADASTRO DE RECEITAS");
        Console.WriteLine("Selecione (1) para cadastrar, (2) para alterar, (3) Remover, (4) Buscar, (5) Sair");
        int escolha = int.Parse(Console.ReadLine());
        
         Bolo[] bolo = new Bolo[100];
        int indice = 0 ;

        switch (escolha)
        {
            case 1:
                
                Console.WriteLine("Entre o nome do bolo: ");
                bolo[indice].nome = Console.ReadLine();

                Console.WriteLine("Entre com a receita: ");
                bolo[indice].ingredientes = Console.ReadLine();

                Console.WriteLine("Sua receita foi cadastrada com sucesso!");
                
                indice++;
                break;
            
            case 2:

                Console.WriteLine("Digite o nome da receita que deseja alterar: ");
                string busca5 = (Console.ReadLine());

                for (int i = 0; i < bolo.Length; i++)
                {
                    if (busca5 == bolo[i].nome)
                    {
                        Console.WriteLine("Receita encontrada, Vc desejar alterar? S/N?");
                        char decisao = char.Parse(Console.ReadLine());
                        if (decisao == 'S')
                        {
                            Console.WriteLine("Entre o nome do bolo: ");
                            bolo[i].nome = (Console.ReadLine()); ;

                            Console.WriteLine("Entre com a receita: ");
                            bolo[i].ingredientes = (Console.ReadLine());

                            Console.WriteLine(" BOLO ALTERADO COM SUCESSO!");
                        }
                        else
                        {
                            Console.WriteLine("CANCELADO");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nenhuma Receita encontrada!");
                    }
                }
                break;

            case 3:

                Console.WriteLine("Digite o nome da receita que deseja procurar: ");
                string busca3 = (Console.ReadLine());

                for (int i = 0; i < bolo.Length; i++)
                {
                    if (busca3 == bolo[i].nome)
                    {
                        Console.WriteLine("Receita encontrada e será removida! vc tem certeza S/N?");
                        char decisao = char.Parse(Console.ReadLine());
                        if (decisao == 'S')
                        {
                           
                            Console.WriteLine("REMOVIDO COM SUCESSO");
                            bolo[i].nome = null;
                            bolo[i].ingredientes = null;
                        }
                        else {
                            Console.WriteLine("CANCELADO");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nenhuma Receita encontrada!");
                    }
                }
                break;

      

            case 4:

                Console.WriteLine("Digite o nome da receita que deseja procurar: ");
                string busca = (Console.ReadLine());

                for (int i =0; i < bolo.Length; i++) {
                    if (busca == bolo[i].nome)
                    {
                        Console.WriteLine("Receita encontrada!");
                        Console.WriteLine("BOLO: " + bolo[i].nome);
                        Console.WriteLine("RECEITA: " + bolo[i].ingredientes);
                        Console.WriteLine("- - - - - - - - - - - -");
                    }
                    else {
                        Console.WriteLine("Nenhuma Receita encontrada!");
                    }
                }
                break;

            case 5:
                // sai do app
                break;

            default:
                break;
        }

        /*
         * 
         * Roberto adora telefones e gostaria de um programa para guardar os seus contatos, 
         * construa um programa que 
         * guarde os contatos de Roberto e permita que ele consulte os seus contatos.
         */
        // --------- aqui é o mesmo principio da lista de bolo

        /*
         * 
         * ->Adriano estava doente e resolveu ir ao hospital,quando chegou 
         * verificou que seu nome estava sendo chamado em um painel, Adriano é 
         * desenvolvedor e decidiu replicar o sitema de chamado do hospital apos chegar em casa. 
         * Faça um programa que simule um sistema de chamado de consultas.
         * Exemplos=> A pessoa escolhe qual é o a categoria da consulta e seu nome 
         * é inserido em uma fila de espera.
         */

        // mesmo esquema da struct acima

        /*
         * 
         * ->Jurandir possue um estacionamento e gostaria de um sistema
         * para gerenciar seu negocio, desenvolva um programa que gerencie 
         * o estacionamento do Jurandir, o sistema deve fazer as seguintes funções:

            1=>Cadastrar o veiculo
            2=>Consultar o veiculo
            3=>Calcular o valor a ser cobrado do estacionamento
            4=>Verificar quais vagas estão disponiveis.
         */
        // mesmo esquema da struct acima
    }
}
