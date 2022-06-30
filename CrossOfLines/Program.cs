/* Задача 43. Напишите программу, которая найдёт точку
пересечения двух прямых, заданных уравнениями y = k1 *
x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 =
9 -> (-0,5; 5,5) */


void PrintArrTwo(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();
    }

}

Console.WriteLine("Введите через пробел k1  b1  k2  b2: ");
string s = Console.ReadLine();



int[,] matrix = new int[2, 2];
int[,] b = new int[2, 1];
string[] numbrs = s.Split(' ');

matrix[0, 0] = int.Parse(numbrs[0]);
matrix[1, 0] = int.Parse(numbrs[2]);
matrix[0, 1] = -1;
matrix[1, 1] = -1;
Console.WriteLine();
PrintArrTwo(matrix);

b[0, 0] = -1 * int.Parse(numbrs[1]);
b[1, 0] = -1 * int.Parse(numbrs[3]);
Console.WriteLine();
PrintArrTwo(b);

int det = matrix[0, 0] * (-1) - (-1) * matrix[1, 0];

if (det == 0)
{
    Console.WriteLine("Точек пересечения нет.");
}
else
{
    int det1 = b[0, 0] * (-1) - (-1) * b[1, 0];
    int det2 = matrix[0, 0] * b[1, 0] - b[0, 0] * matrix[1, 0];

    double crossX = (double) det1 / det;
    double crossY = (double) det2 / det;

    Console.WriteLine($"Координаты точки пересечения: X = {crossX}  Y = {crossY}");
}












