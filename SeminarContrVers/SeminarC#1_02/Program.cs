Console.WriteLine("Введите трехзначное число");
while (true)
{
    string input = Console.ReadLine();
    if (!input.Equals("exit"))
        Console.WriteLine("{0}->{2}", input, input[2]);
    else
        break;
}
