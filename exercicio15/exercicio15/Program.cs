double indice;

Console.Write("Digite o índice de poluição: ");
indice = double.Parse(Console.ReadLine());

if (indice >= 0.5)
{
    Console.WriteLine("Notificar os grupos 1, 2 e 3");
}
else if (indice >= 0.4)
{
    Console.WriteLine("Notificar os grupos 1 e 2");
}
else if (indice >= 0.3)
{
    Console.WriteLine("Notificar o grupo 1");
}
else
{
    Console.WriteLine("Índice aceitável, nenhuma notificação necessária");
}