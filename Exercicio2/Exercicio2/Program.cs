Console.WriteLine("Digite o valor a ser convertido: ");
double valorDolar = double.Parse(Console.ReadLine());

double cotacaoHoje = 5.27;
double valorReal = valorDolar * cotacaoHoje;

Console.WriteLine($"Convertido! Seu valor em dólar (${valorDolar:F2}) será: R${valorReal:F2}");