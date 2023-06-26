// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int rows = Prompt("Введите количество строк: ");
int columns = Prompt("Введите количество столбцов: ");
int[,] firstmatrix = new int[rows, columns];
int[,] secondmatrix = new int[rows, columns];
int[,] resultArray = new int[rows, columns];

Console.WriteLine();

Console.WriteLine("Первая матрица");
GetArray(firstmatrix);
PrintArray(firstmatrix);

Console.WriteLine();

Console.WriteLine("Вторая матрица");
GetArray(secondmatrix);
PrintArray(secondmatrix);
Console.WriteLine();
if (firstmatrix.GetLength(0) != secondmatrix.GetLength(1))
{
    Console.WriteLine(" Нельзя перемножить ");
    return;
}
for (int i = 0; i < firstmatrix.GetLength(0); i++)
{
    for (int j = 0; j < secondmatrix.GetLength(1); j++)
    {
        resultArray[i, j] = 0;
        for (int k = 0; k < firstmatrix.GetLength(1); k++)
        {
            resultArray[i, j] += firstmatrix[i, k] * secondmatrix[k, j];
        }
    }
}


Console.WriteLine("Произведение двух матриц");
PrintArray(resultArray);

int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int val = 0;
    while ((int.TryParse(value, out val)) != true)
    {
        Console.Write("Неверный ввод. Повторите: ");
        value = Console.ReadLine();

    }

    return val;
}



void GetArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}