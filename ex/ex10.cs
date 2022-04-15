using System;
int num;
string bin;
Console.WriteLine("Insira o número: ");
num = Convert.ToInt32(Console.ReadLine());
bin = Convert.ToString(num,2);
Console.WriteLine("Número em binário: " + bin);