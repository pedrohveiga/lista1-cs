double lado;
double area;
double per;

Console.WriteLine("Insira o valor do lado do quadrado:");
lado = Convert.ToDouble(Console.ReadLine());
area = lado * lado;
per = lado * 4;
Console.WriteLine("Área: " + area);
Console.WriteLine("Perímetro: " + per);
