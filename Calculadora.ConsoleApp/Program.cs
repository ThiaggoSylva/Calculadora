
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
    Console.WriteLine("S-Sair");

    Console.WriteLine("Selecione uma opção válida: ");
    string opcaoSelecionada = Console.ReadLine();

    if(opcaoSelecionada == "S")
    {
        deveContinuar = false;

        continue;
    }

    Console.Write("Digite o Primeiro Número: ");
    string strPrimeiroNumero = Console.ReadLine();

    Console.WriteLine();

    Console.Write("Digite o Segundo Número: ");
    string strSegundoNumero = Console.ReadLine();

    Console.WriteLine();

    Console.WriteLine("O Primeiro numero digitado foi: " + strPrimeiroNumero);
    Console.WriteLine("O Segundo numero digitado foi: " + strSegundoNumero);


    Console.WriteLine();

    int primeiroNumero = Convert.ToInt32(strPrimeiroNumero);
    int segundoNumero = Convert.ToInt32(strSegundoNumero);

    int resultado;

    if (opcaoSelecionada == "1")
    {
        resultado = primeiroNumero + segundoNumero;
    }
    else if (opcaoSelecionada == "2")
    {
        resultado = primeiroNumero - segundoNumero;
    }
    else if (opcaoSelecionada == "3")
    {
        resultado = primeiroNumero * segundoNumero;
    }
    else
    {
        if (segundoNumero == 0)
        {
            Console.WriteLine("não é Possivel Dividir por zero");
            return;
        }


        resultado = primeiroNumero / segundoNumero;

    }



    Console.WriteLine("O Resultado é: " + resultado);

    Console.ReadLine();
}



