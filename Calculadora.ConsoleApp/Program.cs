
bool deveContinuar = true;


while (deveContinuar == true)
{
    Console.Clear();

    Console.WriteLine("----------------------------------------------");
    Console.WriteLine("Calculadora 2026");
    Console.WriteLine("----------------------------------------------");

    Console.WriteLine("1-Soma");
    Console.WriteLine("2-Subtração");
    Console.WriteLine("3-Multiplicação");
    Console.WriteLine("4-Divisão");
    Console.WriteLine("5-Tabuada");
    Console.WriteLine("S-Sair");

    Console.WriteLine("Selecione uma opção válida: ");
    string? opcaoSelecionada = Console.ReadLine();

    if(opcaoSelecionada == "S")
    {
        deveContinuar = false;

        continue;
    }

    if(opcaoSelecionada == "5")
    {
        Console.WriteLine("Digite o numero que deseja gerar a tabuada: ");

        int numeroTabuada = Convert.ToInt32(Console.ReadLine());

        for(int contador = 1; contador <= 10; contador=contador + 1 )
        {

            int resultadoTabuada = numeroTabuada * contador;

            string operacaoTabuada = numeroTabuada + "X" + contador + "=" + resultadoTabuada; 
            
            Console.WriteLine(operacaoTabuada);
        }

        Console.ReadLine();
        continue;
    }



    Console.Write("Digite o Primeiro Número: ");
    string? strPrimeiroNumero = Console.ReadLine();

    Console.WriteLine();

    Console.Write("Digite o Segundo Número: ");
    string? strSegundoNumero = Console.ReadLine();

    Console.WriteLine();

    bool primeiroNumeroVazio = string.IsNullOrEmpty(strPrimeiroNumero);
    bool segundoNumeroVazio = string.IsNullOrEmpty(strSegundoNumero);


    if(primeiroNumeroVazio == true || segundoNumeroVazio == true)
    {
        Console.WriteLine("Digite um número válido");
        Console.ReadLine();

        continue;
    }

    Console.WriteLine("O Primeiro numero digitado foi: " + strPrimeiroNumero);
    Console.WriteLine("O Segundo numero digitado foi: " + strSegundoNumero);


    Console.WriteLine();

    decimal primeiroNumero = Convert.ToDecimal(strPrimeiroNumero);
    decimal segundoNumero = Convert.ToDecimal(strSegundoNumero);

    decimal resultado;

    switch(opcaoSelecionada)
    {
        case "1":
            resultado = primeiroNumero + segundoNumero;
            break;

            case "2":
            resultado = primeiroNumero - segundoNumero;
            break;

            case "3":
            resultado = primeiroNumero * segundoNumero;
            break;

            case "4":
             if (segundoNumero == 0)
        {
            Console.WriteLine("não é Possivel Dividir por zero");
            return;
        }

            resultado = primeiroNumero / segundoNumero;
            break;

            default:
                Console.WriteLine("Selecione um numero valido");
                Console.ReadLine();

                continue;

    }

    


    Console.WriteLine("O Resultado é: " + resultado);

    Console.ReadLine();
}



