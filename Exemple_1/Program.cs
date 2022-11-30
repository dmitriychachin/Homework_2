Console.WriteLine("Ввдите трехзначное число");
int num1 = int.Parse(Console.ReadLine());

int num2 = num1 / 10;
int result = num2 % 10;

Console.WriteLine("Среднее число:");
Console.WriteLine($"{result}");