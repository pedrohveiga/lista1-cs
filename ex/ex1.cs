double b;
double h;
double area;
double per;

Console.WriteLine("Insira o valor da base:");
b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Insira o valor da altura:");
h = Convert.ToDouble(Console.ReadLine());
area = b * h;
per = 2 * b + 2 * h;
Console.WriteLine("O perímetro é de: " + per);
Console.WriteLine("O área é de: " + area);