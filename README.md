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
-------------------------------------------------------------------------