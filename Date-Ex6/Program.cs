int option = 0;

Console.WriteLine("Escolha um modo de ver a Data de hoje: ");
Console.WriteLine("1 - FORMATO COMPLETO");
Console.WriteLine("2 - PADRÃO");
Console.WriteLine("3 - APENAS A HORA NO FORMATO DE 24 HORAS");
Console.WriteLine("4 - COM O MÊS POR EXTENSO");

int.TryParse(Console.ReadLine(), out option);


switch (option)
{
	case 1:
        Console.WriteLine(DateTime.Now.ToLongDateString()); break;
	case 2:
        Console.WriteLine(DateTime.Now.ToShortDateString()); break;
	case 3:
        Console.WriteLine(DateTime.Now.ToLongTimeString()); break;
	case 4:
        Console.WriteLine(DateTime.Now.ToString("dd 'de' MMMM 'de' yyyy")); break;
	default:
		Console.WriteLine("Opcão inválida!"); break;
		
}