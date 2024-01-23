// calculadora
string MsgBoasVindas = "Bem vindo a calculadora feita em C#!";

void ExibirLogo()
{
    Console.WriteLine(@"
░█████╗░░█████╗░██╗░░░░░░█████╗░██╗░░░██╗██╗░░░░░░█████╗░██████╗░░█████╗░██████╗░░█████╗░
██╔══██╗██╔══██╗██║░░░░░██╔══██╗██║░░░██║██║░░░░░██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔══██╗
██║░░╚═╝███████║██║░░░░░██║░░╚═╝██║░░░██║██║░░░░░███████║██║░░██║██║░░██║██████╔╝███████║
██║░░██╗██╔══██║██║░░░░░██║░░██╗██║░░░██║██║░░░░░██╔══██║██║░░██║██║░░██║██╔══██╗██╔══██║
╚█████╔╝██║░░██║███████╗╚█████╔╝╚██████╔╝███████╗██║░░██║██████╔╝╚█████╔╝██║░░██║██║░░██║
░╚════╝░╚═╝░░╚═╝╚══════╝░╚════╝░░╚═════╝░╚══════╝╚═╝░░╚═╝╚═════╝░░╚════╝░╚═╝░░╚═╝╚═╝░░╚═╝");
    Console.WriteLine(MsgBoasVindas);
}

void OpcoesDoMenu ()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para soma.");
    Console.WriteLine("Digite 2 para subtração.");
    Console.WriteLine("Digite 3 para multiplicação.");
    Console.WriteLine("Digite 4 para divisão.");
    Console.WriteLine("Digite 0 para sair.");

    Console.Write("\n Digite a sua opção: ");
    String opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNum = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNum)
    {
        case 1: Soma();
            break;
        case 2: Subtrair();
            break;
        case 3: Multiplar();
            break;
        case 4: Dividir();
            break;
        case 0: Console.WriteLine("Ate mais :)");
            break;
        default: Console.WriteLine("Opção Inválida!");
            break;
    }
}

void Soma()
{
    Console.Clear();
    Double num1, num2;

    Console.Write("Digite o primeiro número: ");
    num1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Digite o segundo número: ");
    num2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
    Thread.Sleep(2000);
    Console.Clear();
    OpcoesDoMenu();
}

void Subtrair(){

    Console.Clear();
    Double num1, num2;

    Console.Write("Digite o primeiro número: ");
    num1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Digite o primeiro número: ");
    num2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
    Thread.Sleep(2000);
    Console.Clear();
    OpcoesDoMenu();
}

void Multiplar()
{
    Console.Clear();
    Double num1, num2;

    Console.Write("Digite o primeiro número: ");
    num1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Digite o primeiro número: ");
    num2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
    Thread.Sleep(2000);
    Console.Clear();
    OpcoesDoMenu();
}

void Dividir()
{
    Console.Clear();
    Double num1, num2;

    Console.Write("Digite o primeiro número: ");
    num1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Digite o primeiro número: ");
    num2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
    Thread.Sleep(2000);
    Console.Clear();
    OpcoesDoMenu();

}

OpcoesDoMenu();