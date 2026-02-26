Console.WriteLine("Digite a distaçia a rodar: ");
double km = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o quanto você abasteceu: ");
double litros = double.Parse(Console.ReadLine());

double consumo = (km / litros);
Console.WriteLine($"O consumo do carro é: {consumo:F2} litros por quilometro");