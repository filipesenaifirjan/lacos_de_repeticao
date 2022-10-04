
int soma = 0, numero = 0; //as variáveis podem ser declaradas na mesma linha desde que sejam do mesmo tipo(inteiro)



do  //vai executar o código independente da execução
{

Console.WriteLine("Digite um número:(0 para parar)");
numero = Convert.ToInt32(Console.ReadLine());

 soma +=numero;


} while(numero != 0); //!= significa diferente

Console.WriteLine($"Total da soma dos números digitados é: {soma}");

