int qtdMin, qtdMax;
double estoqueMedio;

    Console.WriteLine("Digite a quantidade mínima: ");
    qtdMin = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite a quantidade maxima: ");
    qtdMax = int.Parse(Console.ReadLine());

   estoqueMedio = (qtdMin + qtdMax) / 2.0;

Console.WriteLine("Estoque médio: " + estoqueMedio);