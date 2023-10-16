using System;
class URI {

    static void Main(string[] args)  {

        Console.WriteLine("Insira o valor em Segundos abaixo: ");
        int N = int.Parse(Console.ReadLine());
        int h, m, s;

        h = N / 3600;
        m = (N % 3600) / 60;
        s = (N % 3600) % 60;

        Console.WriteLine("Valor em Horas + Minutos + Segundos");
        Console.WriteLine(h + ":" + m + ":" + s);

    }

}