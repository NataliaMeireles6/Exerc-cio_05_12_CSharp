using System;

class Program {
  public static void Main (string[] args) {
// declara uma variável do tipo Inteiro e uma do tipo caractere (texto)
// A variável String recebe o valor digitado e armazena.
Int16 num; 
String entrada;
//Escreva
Console.WriteLine("Digite um número");
//Leia
entrada = Console.ReadLine();
// Converte a entrada em texto em formato de numérico
num = Int16.Parse(entrada);
if(num%2==0)
//se(num%2==0) entao
//C# a comparação é feita com ==
{
  Console.WriteLine("Número par");
//Código
}
    else{
  Console.WriteLine("Número ímpar");
    }
}
}