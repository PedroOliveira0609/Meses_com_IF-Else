using System;

namespace If_Esel
{
    class Program
    {
         static void Main(string[] args)
        {
            String mes;
            Console.WriteLine("Teste de quantidade de dias dos meses!");
            Console.WriteLine("");
            Console.WriteLine("Para começar, observe a tabela e digite o mês desejado.");
            Console.WriteLine("");
            Console.WriteLine("|  Janeiro    |");
            Console.WriteLine("|  Fevereiro  |");
            Console.WriteLine("|  Março      |");
            Console.WriteLine("|  Abril      |");
            Console.WriteLine("|  Maio       |");
            Console.WriteLine("|  Junho      |");
            Console.WriteLine("|  Julho      |");
            Console.WriteLine("|  Agosto     |");
            Console.WriteLine("|  Setembro   |");
            Console.WriteLine("|  Outubro    |");
            Console.WriteLine("|  Novembro   |");
            Console.WriteLine("|  Dezembro   |");
            Console.WriteLine("");
            Console.WriteLine("Consulte a tabela e digite o mês desejado: ");
            mes = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("");
            if (mes == "Janeiro")
            {
                Console.WriteLine("O MÊS DIGITADO POSSUI 31 DIAS!");
                Console.WriteLine("");
            }
            else if (mes == "Fevereiro")
            {
                Console.WriteLine("O MÊS DIGITADO POSSUI 28/29 DIAS!");
                Console.WriteLine("");
            }
            else if (mes == "Março")
            {
                Console.WriteLine("O MÊS DIGITADO POSSUI 31 DIAS!");
                Console.WriteLine("");
            }
            else if (mes == "Abril")
            {
                Console.WriteLine("O MÊS DIGITADO POSSUI 30 DIAS!");
                Console.WriteLine("");
            }
            else if (mes == "Maio")
            {
                Console.WriteLine("O MÊS DIGITADO POSSUI 31 DIAS!");
                Console.WriteLine("");
            }
            else if (mes == "Junho")
            {
                Console.WriteLine("O MÊS DIGITADO POSSUI 30 DIAS!");
                Console.WriteLine("");
            }
            else if (mes == "Julho")
            {
                Console.WriteLine("O MÊS DIGITADO POSSUI 31 DIAS!");
                Console.WriteLine("");
            }
            else if (mes == "Agosto")
            {
                Console.WriteLine("O MÊS DIGITADO POSSUI 31 DIAS!");
                Console.WriteLine("");
            }
            else if (mes == "Setembro")
            {
                Console.WriteLine("O MÊS DIGITADO POSSUI 30 DIAS!");
                Console.WriteLine("");
            }
            else if (mes == "Outubro")
            {
                Console.WriteLine("O MÊS DIGITADO POSSUI 31 DIAS!");
                Console.WriteLine("");
            }
            else if (mes == "Novembro")
            {
                Console.WriteLine("O MÊS DIGITADO POSSUI 30 DIAS!");
                Console.WriteLine("");
            }
            else if (mes == "Dezembro")
            {
                Console.WriteLine("O MÊS DIGITADO POSSUI 31 DIAS!");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Digito Inválido");
                Console.WriteLine("");
            }
        }
    }
}
