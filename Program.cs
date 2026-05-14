/*
DEsenvolva a solução aqui em Program.cs, quando terminar cole o conteúdo 
no respectivo arquivo
*/


static void opcaoCalculo(string opcao, double numero1, double numero2)
{
    double resultado = 0;
    if (opcao == "+")
    {
        resultado = numero1 + numero2;
        Console.WriteLine($"Resultado da soma: {resultado}");
    }
    else if (opcao == "-")
    {
        resultado = numero1 - numero2;
        Console.WriteLine($"Resultado da subtração: {resultado}");
    }
    else if (opcao == "*")
    {
        resultado = numero1 * numero2;
        Console.WriteLine($"Resultado da multiplicação: {resultado}");
    }
    else if (opcao == "/")
    {
        resultado = numero1 / numero2;
        Console.WriteLine($"Resultado da divisão: {resultado}");
    }
    else
    {
        Console.WriteLine("Opção inválida.");
    }
}

static void Menu()
{
    string continuar = "s";
    while (continuar == "s" || continuar == "S")
    {
        Console.Clear();
        Console.WriteLine("=== CALCULADORA ===");
        Console.WriteLine("+ Soma");
        Console.WriteLine("- Subtração");
        Console.WriteLine("* Multiplicação");
        Console.WriteLine("/ Divisão");
        Console.Write("Escolha uma opção: ");
        string opcao = Console.ReadLine()!;

        Console.Write("Digite o primeiro número: ");
        double numero1 = double.Parse(Console.ReadLine()!);

        Console.Write("Digite o segundo número: ");
        double numero2 = double.Parse(Console.ReadLine()!);

        opcaoCalculo(opcao, numero1, numero2);

        Console.WriteLine();
        Console.Write("Deseja fazer outro cálculo? (s/n): ");
        continuar = Console.ReadLine()!;
    }
}

static void ExecutarSistema()
{
    Menu();
    Console.Write("Fim de programa!!");
}

ExecutarSistema();



