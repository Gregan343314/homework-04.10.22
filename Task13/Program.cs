// Задача №13
 Console.Clear();
 Console.WriteLine("Введите число: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int n1 = 0;     
        while (n < 100)
  {
        Console.Write("Третьей цифры нет! Введите число: ");
        n = Convert.ToInt32(Console.ReadLine());
  }
    if (n > 99 && n < 1000) 
    n1 = n % 10;
     else
    do 
 {
     n= n/10;
     n1 = n % 10;
 }
 while (n > 999);

  Console.WriteLine($"Третья цифра числа: {n1}");