/* Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3 */

Console.Write("Введите через пробел несколько чисел: ");
string s = Console.ReadLine();
string[] numbs = s.Split(' ');

int count = 0;

for (int i = 0; i < numbs.Length; i++)
{
    int num = int.Parse(numbs[i]);
    if (num > 0)
    {
        count++;
    }
}

if (count == 0)
{
    Console.WriteLine("Нет чисел больше ноля.");
}
else
{
    Console.WriteLine("Чисел больше ноля: " + count);
}