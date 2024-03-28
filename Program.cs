// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;
using System.Diagnostics.Contracts;
int n1 = 10;
int contador = 0;

while (contador <= 10)
{
    Console.WriteLine($"{n1} X {contador} = {n1 * contador}");
    contador++;

    if (contador == 6)
    { //serve para interromper o fluxo de execução mesmo a condição do while sendo verdadeira
        break;
    }
}

// for (int contador = 0; contador <= 10; contador++)
// {
//     Console.WriteLine($"{n1} X {contador} = {n1 * contador}");
// }