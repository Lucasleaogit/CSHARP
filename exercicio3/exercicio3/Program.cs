

        Console.Write("Digite o valor total do salario: R$ ");
        double totalVendas = double.Parse(Console.ReadLine());

        double comissao = totalVendas * 0.05;

        Console.WriteLine($"Comissão do vendedor: R$ {comissao:F2}");