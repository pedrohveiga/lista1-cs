int num;
int num_suc;
int num_ant;
Console.WriteLine("Insira o número: ");
num = Convert.ToInt32(Console.ReadLine());
num_ant = num - 1;
num_suc = num + 1;
Console.WriteLine("O número inserido foi: " + num);
Console.WriteLine("Seu antecessor é " + num_ant + " e seu sucessor é " + num_suc);
