// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

Tabuada();

static void Tabuada()
{
    Console.WriteLine("Escolha o número da tabuada:");
    float n1 = float.Parse(Console.ReadLine());

    for (int contador = 0; contador <= 10; contador++)
    {
        Console.WriteLine($"{n1} X {contador} = {n1 * contador}");
    }

}
Console.WriteLine("Fim da tabuada!");
Console.WriteLine("Para gerar outra tabuada pressione 1, para sair digite 0");
Console.ReadKey();

short res = short.Parse(Console.ReadLine());
switch (res)
{
    case 1: Tabuada(); break;
    case 0: System.Environment.Exit(0); break;
    default: Tabuada(); break;

}