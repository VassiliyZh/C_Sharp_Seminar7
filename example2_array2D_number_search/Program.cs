// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int InputNumber(string message)
{
    System.Console.Write(message + ": ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
void FillArray2D(double[,] array2D)
{
    Random rnd = new Random();

    for(int i = 0; i<array2D.GetLength(0); i++) 
    {
        for(int j = 0; j<array2D.GetLength(1); j++) 
        {
            array2D[i, j] = rnd.Next(0, 100);
        }
    }
}

void PrintArray2D(double[,] array2D)
{
    for(var i = 0; i<array2D.GetLength(0); i++) 
    {
        for(var j = 0; j<array2D.GetLength(1); j++) 
           {
             System.Console.Write(string.Format ("{0, 5}", array2D[i, j]));
           }
        System.Console.WriteLine();
    }
}

int m = 3;
int n = 4;
double[,] arrayNew = new double[m, n];
PrintArray2D(arrayNew);
FillArray2D(arrayNew);
System.Console.WriteLine();
PrintArray2D(arrayNew);
System.Console.WriteLine();

int numberInRow = InputNumber("Введите номер строки");
int numberInColumn = InputNumber("Введите номер столбца");

if(numberInRow - 1 > arrayNew.GetLength(0) 
    || numberInColumn - 1 > arrayNew.GetLength(1))
    {
        System.Console.WriteLine("Такого числа в массиве нет");
    }
else
    {
        System.Console.WriteLine("Значение ячеки: " 
            + arrayNew[numberInRow-1, numberInColumn - 1]);
    }