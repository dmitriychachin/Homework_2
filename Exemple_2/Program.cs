Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());

if (num < 100){
    Console.WriteLine($"Число {num} не имеет третей цифры");
} else {

    Console.Write($"Третье цифра числа {num} равна ");

    while (num > 999)
    {
        num = num / 10;
    }

    int result = num % 10;
    Console.Write($"{result}");
}