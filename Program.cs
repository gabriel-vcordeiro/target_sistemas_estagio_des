
using System.ComponentModel;

Ex1();
Ex2();
Console.WriteLine("Insira a palavra:");
string palavra = Console.ReadLine();
Console.WriteLine($"{palavra} ao contrário: {Reverter(palavra)}");

//Questão 1: Exibir o valor de soma = 91
void Ex1() {
int indice = 13, soma = 0, k = 0;
while (k < indice)
{

k = k + 1;

soma = soma + k;
}
Console.WriteLine($"O valor de soma é: {soma}.");}

//Sequência de Fibonacci
void Ex2(){
 int numero1 = 0;
 int numero2 = 1;
 Console.WriteLine("Insira seu número: ");
 int numerodesejado = int.Parse(Console.ReadLine());
 while (numero2 < numerodesejado)
 {
    int temp = numero1;
    numero1 = numero2;
    numero2 = numero1 + temp;

 }
 if (numero2 == numerodesejado || numerodesejado == 0)
 {
    Console.WriteLine($"O número {numerodesejado} está na sequência de Fibonacci.");
 }
 else
 {
    Console.WriteLine($"O número não está na sequência de Fibonacci.");
 }
}


//Exercício 5
string Reverter(string palavra){
    string palavra_contrario = "";
    for (int i = palavra.Length-1; i >= 0 ; i-- )
    {
        palavra_contrario += palavra[i];
    }
    return palavra_contrario;
}