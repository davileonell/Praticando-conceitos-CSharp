int num1 = 0, num2 = 0;

Console.Write("Digite um número inteiro: ");

while (num1 <= 0)
{
    // Tenta converter. Se der certo, cria a variável 'numero'
    if (int.TryParse(Console.ReadLine(), out num1))
    {
        Console.WriteLine("Digite outro número inteiro: ");

        while (num2 <= 0)
        {
            if (int.TryParse(Console.ReadLine(),out num2))
            {
                Console.WriteLine($"Soma: {num1 + num2} ");
                Console.WriteLine($"Subtração: {num1 - num2}");
                Console.WriteLine($"Multiplicação: {num1 * num2}");
                Console.WriteLine($"Divisão: {num1 / num2}");
                Console.WriteLine($"Média: {(num1 + num2) / 2}");
            }
            else
            {
                Console.WriteLine("Erro: Você não digitou um número inteiro válido.");
                Console.WriteLine("Digite um número válido!");
            }
        }
    }
    else
    {
        Console.WriteLine("Erro: Você não digitou um número inteiro válido.");
        Console.WriteLine("Digite um número válido!");
    }
}