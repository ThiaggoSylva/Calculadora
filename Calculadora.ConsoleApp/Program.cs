using System;

class Program
{
    static string[] historicoOperacoes = new string[100];
    static int contadorOperacoes = 0;

    static void Main()
    {
        while (true)
        {
            Console.Clear();

            ExibirMenu();

            string? opcao = Console.ReadLine();

            if (opcao?.ToUpper() == "S")
                return;

            if (opcao == "5")
            {
                MostrarTabuada();
                continue;
            }

            if (opcao == "6")
            {
                MostrarHistorico();
                continue;
            }

            decimal primeiroNumero = LerNumero("Digite o primeiro número: ");
            decimal segundoNumero = LerNumero("Digite o segundo número: ");

            bool operacaoValida = Calcular(opcao, primeiroNumero, segundoNumero);

            if (operacaoValida == false)
                continue;

            Console.WriteLine("\nPressione ENTER para continuar...");
            Console.ReadLine();
        }
    }

    static void ExibirMenu()
    {
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("Calculadora 2026");
        Console.WriteLine("----------------------------------------------");

        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");
        Console.WriteLine("5 - Tabuada");
        Console.WriteLine("6 - Histórico de Operações");
        Console.WriteLine("S - Sair");

        Console.Write("\nSelecione uma opção: ");
    }

    static decimal LerNumero(string mensagem)
    {
        Console.Write(mensagem);

        while (!decimal.TryParse(Console.ReadLine(), out decimal numero))
        {
            Console.Write("Número inválido. Digite novamente: ");
        }

        return numero;
    }

    static bool Calcular(string? opcao, decimal n1, decimal n2)
    {
        decimal resultado;
        string textoOperacao;

        switch (opcao)
        {
            case "1":
                resultado = n1 + n2;
                textoOperacao = $"{n1} + {n2} = {resultado}";
                break;

            case "2":
                resultado = n1 - n2;
                textoOperacao = $"{n1} - {n2} = {resultado}";
                break;

            case "3":
                resultado = n1 * n2;
                textoOperacao = $"{n1} x {n2} = {resultado}";
                break;

            case "4":
                if (n2 == 0)
                {
                    Console.WriteLine("Não é possível dividir por zero.");
                    return false;
                }

                resultado = n1 / n2;
                textoOperacao = $"{n1} / {n2} = {resultado}";
                break;

            default:
                Console.WriteLine("Opção inválida.");
                return false;
        }

        SalvarHistorico(textoOperacao);

        Console.WriteLine($"\nResultado: {resultado}");

        return true;
    }

    static void MostrarTabuada()
    {
        Console.Write("\nDigite o número da tabuada: ");

        if (!int.TryParse(Console.ReadLine(), out int numero))
        {
            Console.WriteLine("Número inválido.");
            Console.ReadLine();
            return;
        }

        Console.WriteLine();

        for (int i = 1; i <= 10; i++)
        {
            int resultado = numero * i;
            Console.WriteLine($"{numero} x {i} = {resultado}");
        }

        Console.ReadLine();
    }

    static void MostrarHistorico()
    {
        Console.WriteLine("\nHistórico de Operações");
        Console.WriteLine("----------------------------------------------");

        for (int i = 0; i < contadorOperacoes; i++)
        {
            Console.WriteLine(historicoOperacoes[i]);
        }

        Console.ReadLine();
    }

    static void SalvarHistorico(string operacao)
    {
        if (contadorOperacoes < historicoOperacoes.Length)
        {
            historicoOperacoes[contadorOperacoes] = operacao;
            contadorOperacoes++;
        }
    }
}