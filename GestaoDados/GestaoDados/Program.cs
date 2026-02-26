using System;
using System.Collections.Generic;
using Autor;
using Relatorio;

public class program
{ public static void Main(string[] args)
    {
        Autor autor1 = new Autor("Stephen", "King");
        Autor autor2 = new Autor("J. R. R.", "Tolkien");

        Relatorio relatorio1 = new Relatorio("O Senhor dos Aneis", "Uma Aventura Fantastica",
           "Texto....", "image.jpg","link.com");
        Relatorio relatorio2 = new Relatorio("It: A Coisa", "Um Romance de Terror",
              "Texto....", "image.jpg", "link.com");

        Autoria autoria1 = new Autoria(autor1, relatorio1, 1, false);
        Autoria autoria2 = new Autoria(autor2, relatorio2, 2, false);

        autor1.ExibirInfo();
        Console.WriteLine($"{autoria1.Relatorio.Titulo} por {autoria1.Autor.Nome}");

        Acesso acesso1 = new Acesso(1, DateTime.Now);
        relatorio1.RegistrarAcesso(acesso1);
    }
}