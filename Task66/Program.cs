// Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int sum(int m, int n)
{
	if(n == m)
		return n;
    return n + sum(m, n-1);
}
	
Console.Clear();
Console.Write("Введите первое число ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(sum(m, n));