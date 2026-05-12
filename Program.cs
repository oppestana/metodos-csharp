/*
DEsenvolva a solução aqui em Program.cs, quando terminar cole o conteúdo 
no respectivo arquivo
*/


static int LerNumero(string mensagem)
{
    Console.Write(mensagem);
    int numero = int.Parse(Console.ReadLine()!);
    return numero;
}

static void ExibirTabuada(int numero)
{
    Console.WriteLine($"Tabuada do {numero}:");
    int tabuada = 0;
    while (tabuada <= 10)
    {
        Console.WriteLine($"{numero} X {tabuada} = {numero * tabuada}");
        tabuada++;
    }
}    
static void ExecutarSistema()
{
    int numero = LerNumero("Digite um numero para ver tabuada: ");
    ExibirTabuada(numero);
}

ExecutarSistema();