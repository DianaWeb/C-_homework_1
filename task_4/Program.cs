/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */
System.Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b & a > c)
{
	System.Console.Write("max = ");
	System.Console.WriteLine(a);
}
if (b > a & b > c)
{
	System.Console.Write("max = ");
	System.Console.WriteLine(b);
}
if (c > a & c > b)
{
	System.Console.Write("max = ");
	System.Console.WriteLine(c);
}