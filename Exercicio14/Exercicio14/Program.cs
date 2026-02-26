int numero;
int somaPares = 0;
int somaImpares = 0;

Console.Write("Digite um número: ");
numero = int.Parse(Console.ReadLine());

while (numero >= 0)
{
    if (numero % 2 == 0)
    {
        somaPares += numero;
    }
    else
    {
        somaImpares += numero;
    }

    Console.Write("Digite um número: ");
    numero = int.Parse(Console.ReadLine());
}

Console.WriteLine("Soma dos pares: " + somaPares);
Console.WriteLine("Soma dos ímpares: " + somaImpares);