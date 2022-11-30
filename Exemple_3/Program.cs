Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());

if (num == 1 || num == 2 || num == 3 || num == 4 || num == 5){
    Console.WriteLine("No");
}else if (num == 6 || num == 7){
    Console.WriteLine("Yes");
} else 
    Console.WriteLine("Not day a week");