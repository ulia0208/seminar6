// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.WriteLine(" Есть два уравнения"+
"y = n1 * x + m1,"+ 
"y = n2 * x + m2");

Console.WriteLine(" Введите параметры первого уравнения");
int n1 = Convert.ToInt32(Console.ReadLine());
int m1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" Введите параметры втор5 ого уравнения");
int n2 = Convert.ToInt32(Console.ReadLine());
int m2 = Convert.ToInt32(Console.ReadLine());

 

if (n1 == n2)
{
    Console.WriteLine($"Прямые параллельны");
      
}
    else
{
        
     double x = (m2-m1)/(n1-n2);
    double y = n2 * x + m2; 
    Console.WriteLine($"X: {x}, Y: {y}");  
}


