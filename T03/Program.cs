// Напишите программу, в которой пользователь вводит два числа и выводит результат их умножения. 
// Запрашивать ввод, пока числа не будут в диапазоне от 0 до 10.

Console.Clear();
while(true)
{
    Console.WriteLine("Введите первое число от 0 до 10");
    int numA = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число от 0 до 10");
    int numB = Convert.ToInt32(Console.ReadLine());
    if(numA > 0 && numA <10 && numB > 0 && numB < 10)
    {
        int result = numA * numB;
        Console.WriteLine(result);
        break;
    }
}

