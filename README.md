# lacos_de_repeticao
Laços de repetição em C#



----------------------------------------------------
Usando laço for:

int numero = 5;

for(int contador = 1; contador <= 5; contador ++)
{
Console.WriteLine($"{numero} x {contador} = {numero * contador}");
}
----------------------------------------------------
usando o while:

int numero = 5;
int contador = 0;


while (contador <=10)
{
Console.WriteLine($"{numero} x {contador} = {numero * contador}");
contador++;

}
//esse é mais simples por que ele recebe apenas a condição, porém precisa ficar esperto pra não cair em loop infinito
---------------------------------------------------------
interrompendo com o break:
// o break também pode ser usado com o for

int numero = 5;
int contador = 0;


while (contador <=10)
{
Console.WriteLine($"{numero} x {contador} = {numero * contador}");
contador++;

if (contador == 5)
{
    break;
}

}
-------------------------------------------------------------
usando o do while:

int soma = 0, numero = 0; //as variáveis podem ser declaradas na mesma linha desde que sejam do mesmo tipo(inteiro)



do  //vai executar o código independente da execução
{

Console.WriteLine("Digite um número:(0 para parar)");
numero = Convert.ToInt32(Console.ReadLine());

 soma +=numero;


} while(numero != 0); //!= significa diferente

Console.WriteLine($"Total da soma dos números digitados é: {soma}");
------------------------------------------------------------
construindo um menu interativo:

string opcao;

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
-----------------------------------------------------