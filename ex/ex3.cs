using System;
double raio;
double area;
double comp;

Console.WriteLine("Insira o valor do raio da circunferência:");
raio = Convert.ToDouble(Console.ReadLine()!);
area = Math.PI * Math.Pow(raio,2);
comp = 2 * Math.PI * raio;
Console.WriteLine("Comprimento: " + comp);
Console.WriteLine("Área: " + area);