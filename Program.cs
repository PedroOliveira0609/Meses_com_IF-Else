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
            MES = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("");
            if (MES == "Janeiro")
            {
                Console.WriteLine("O MÊS DIGITADO POSSUI 31 DIAS!");
                Console.WriteLine("");
            }
            else if (MES == "Fevereiro")
            {
                Console.WriteLine("O MÊS DIGITADO POSSUI 28/29 DIAS!");
                Console.WriteLine("");
            }
            else if (MES == "Março")
            {
                Console.WriteLine("O MÊS DIGITADO POSSUI 31 DIAS!");
                Console.WriteLine("");
            }
            else if (MES == "Abril")
            {
                Console.WriteLine("O MÊS DIGITADO POSSUI 30 DIAS!");
                Console.WriteLine("");
            }
            else if (MES == "Maio")
            {
                Console.WriteLine("O MÊS DIGITADO POSSUI 31 DIAS!");
                Console.WriteLine("");
            }
            else if (MES == "Junho")
            {
                Console.WriteLine("O MÊS DIGITADO POSSUI 30 DIAS!");
                Console.WriteLine("");
            }
            else if (MES == "Julho")
            {
                Console.WriteLine("O MÊS DIGITADO POSSUI 31 DIAS!");
                Console.WriteLine("");
            }
            else if (MES == "Agosto")
            {
                Console.WriteLine("O MÊS DIGITADO POSSUI 31 DIAS!");
                Console.WriteLine("");
            }
            else if (MES == "Setembro")
            {
                Console.WriteLine("O MÊS DIGITADO POSSUI 30 DIAS!");
                Console.WriteLine("");
            }
            else if (MES == "Outubro")
            {
                Console.WriteLine("O MÊS DIGITADO POSSUI 31 DIAS!");
                Console.WriteLine("");
            }
            else if (MES == "Novembro")
            {
                Console.WriteLine("O MÊS DIGITADO POSSUI 30 DIAS!");
                Console.WriteLine("");
            }
            else if (MES == "Dezembro")
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
