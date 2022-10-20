

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Сколько чисел будем вводить?");

int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите числа");
int j=0;
for (int i=0; i<n; i++)
{
    int m = Convert.ToInt32(Console.ReadLine());
    
    if (m>0)
    {
        j++;
    }
    
}

Console.WriteLine($"{j}  положительных чисел");






