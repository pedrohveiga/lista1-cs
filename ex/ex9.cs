double F=0,C=0;
Console.WriteLine("Insira a temperatura em Farenheit: ");
F = Convert.ToDouble(Console.ReadLine());
C = (F - 32) * (5/9);
Console.WriteLine("A temperatura de " + F + " graus farenheit é de " + C + " graus celsius");