// За каждый месяц банк начисляет к сумме вклада 7%. Напишите программу, в которой пользователь вводит сумму вклада и количество месяцев, 
// а банк вычисляет конечную сумму вклада с учетом начисления процентов за каждый месяц. Для вычисления используйте цикл for и тип данных decimal

Console.Clear();
Console.WriteLine("Введите начальную сумму вклада: ");
decimal vklad = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Введите количество месяцев: ");
int month = Convert.ToInt32(Console.ReadLine());
decimal total = vklad;
for(int count = 1; count <= month; count++)
    total = total * 1.07M;
Console.WriteLine($"При сумме вклада {vklad} через {month} месяцев вы получите {total}");