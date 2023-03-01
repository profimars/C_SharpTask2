//Задача 2
//Напишите программу, которая на вход принимает два числа, и выдает какое число большее, а какое меньшее
Console.WriteLine("Введите первое число");
int q1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int q2 = Convert.ToInt32(Console.ReadLine());
int max = 0;
int min = 0;
bool flag = false;
if (q1 > q2)
{
    max = q1;
    min = q2;
}
else if (q1 < q2)
{
    max = q2;
    min = q1;
}
else
    flag = true;
if (flag == true)
    Console.WriteLine("Введенные числа равны");
else
{
    Console.WriteLine("Максимальное число = " + max);
    Console.WriteLine("Минимальное число = " + min);
}
