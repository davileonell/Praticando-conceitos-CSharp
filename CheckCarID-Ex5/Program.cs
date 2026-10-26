Boolean valid = false;
string plate = "";

Console.WriteLine("Digite uma placa de um veículo: ");
while (valid ==false)
{
    plate = Console.ReadLine().Replace(" ", "");

    if (plate.Length == 7 &&
        plate.Take(3).All(char.IsLetter) &&
        plate.Substring(3,1).All(char.IsNumber) &&
        plate.Substring(4, 1).All(char.IsLetter) &&
        plate.Substring(5, 2).All(char.IsNumber))
    {
        valid = true;
    }
    else
    {
        Console.WriteLine("A placa deve seguir o padrão brasileiro");
    }


}

Console.WriteLine($"Placa válida: {plate}");



