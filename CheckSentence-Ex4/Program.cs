Console.WriteLine("Escreva alguma coisa!");

var text = Console.ReadLine();

int qtd = text.Replace(" ","").Length;

text = text.Replace(" ","");

Console.WriteLine($"A quantidade de caracteres é: {qtd}, texto({text})");
