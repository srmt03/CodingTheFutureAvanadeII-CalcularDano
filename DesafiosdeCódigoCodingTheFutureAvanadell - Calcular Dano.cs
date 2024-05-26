using System;

class Program
{
    static int CalcularDano(int ataque, int defesa)
    {
      int danoCausado = ataque - defesa;
      
      if (danoCausado < 0) 
      {
        danoCausado = 0;
      }
      
      return danoCausado;
    }

    static void Main(string[] args)
    {
        // Valor de Ataque
        int ataque = int.Parse(Console.ReadLine());

        // Valor de Defesa
        int defesa = int.Parse(Console.ReadLine());

        // Valor do Dano
        int danoCausado = CalcularDano(ataque, defesa);
        Console.WriteLine("O dano causado pelo ataque foi: " + danoCausado);
    }
}