﻿string opcao;

while(true)
{
    Console.Clear();//ele vai limpar o console
    Console.WriteLine("Digite a sua opção: ");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - encerrar");

    opcao = Console.ReadLine();

switch(opcao) 
{
case "1":
Console.WriteLine("Cadastro de Cliente");
break;
case "2":
Console.WriteLine("Busca de Cliente");
break;
case "3":
Console.WriteLine("Apagar de Cliente");
break;
case "4":
Console.WriteLine("Encerrar");
Environment.Exit(0);
break;
default:

Console.WriteLine("Opção inválida");
break;
}

}