// Задание №15
 Console.Clear();
 Console.Write("Введите день недели: ");
     int n = Convert.ToInt32(Console.ReadLine());

    while (n <1 || n > 7)
 {
        Console.Write("Ошибка! Введите день недели:");
        n = Convert.ToInt32(Console.ReadLine());
 }
    if (n < 6)
        Console.WriteLine("Рабочий");
    else
        Console.WriteLine("Выходной");