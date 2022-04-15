int idade, mes, ano;
Console.WriteLine("Insira sua idade em dias:");
idade = Convert.ToInt32(Console.ReadLine());
ano = idade/365;
mes = ano * 12;
Console.WriteLine("A idade em dias é "+ idade +" dias");
Console.WriteLine("A idade em meses é de "+ mes +" mês(es)");
Console.WriteLine("A idade em anos é de " + ano + " ano(s)");