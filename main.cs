using System;

class Program {
  public static void Main (string[] args) {
  
Int16 num; 
String entrada;

Console.WriteLine("Digite um número");
entrada = Console.ReadLine();

num = Int16.Parse(entrada);

    if(num%2==0)
{
  Console.WriteLine("Número par");

}
    else{
  Console.WriteLine("Número ímpar");
    }
}
}