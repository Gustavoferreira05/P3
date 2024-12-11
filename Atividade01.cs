/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Digite um número :");
    float n1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Digite outro número:");
    float n2 = float.Parse(Console.ReadLine());
    Console.WriteLine("Digite outro número:");
    float n3 = float.Parse(Console.ReadLine());
    Console.WriteLine("Digite outro número:");
    float n4 = float.Parse(Console.ReadLine());
    float Media = n1 + n2 + n3 + n4/4;
    if(Media > 7.0){
        Console.WriteLine($"Aluno Aprovado!");
    }
    else if(Media < 5.0){
        Console.WriteLine("Aluno Reprovado!");
    }
    else if(Media > 5.0 && Media <= 6.9){
        Console.WriteLine("Aluno em Exame!");
        Console.WriteLine("Digite a nota do exame:");
        float exame  = float.Parse(Console.ReadLine());
        
        float MediaExame = exame + Media / 2;
        
        if(MediaExame >= 5.0){
            Console.WriteLine("Aluno Aprovado!");
            Console.WriteLine($"A média de seu exame :{MediaExame}");
        }
        else{
            Console.WriteLine("Aluno Reprovado!");
            Console.WriteLine($"A média de seu exame :{MediaExame}");
        }
    }
    
  }
}