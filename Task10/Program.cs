// Задание №10
Console.Clear();
Console.WriteLine("Введите трехзначное число.\nДля выхода из программы команда Exit.");
    while(true)
    {
        string input = Console.ReadLine();
        if(!input.Equals("exit"))
            Console.WriteLine("{0}->{1}",input, input[1]);
        else
            break;
    }
