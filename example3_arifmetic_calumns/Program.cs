// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void FillArray2D(double[,] array2D)
{
    Random rnd = new Random();

    for(int i = 0; i<array2D.GetLength(0); i++) 
    {
        for(int j = 0; j<array2D.GetLength(1); j++) 
        {
            array2D[i, j] = Convert.ToDouble(rnd.Next(0, 100));
        }
    }
}

void PrintArray2D(double[,] array2D)
{
    for(int i = 0; i<array2D.GetLength(0); i++) 
    {
        for(int j = 0; j<array2D.GetLength(1); j++) 
           {
             System.Console.Write(string.Format ("{0, 5}", array2D[i, j]));
           }
        System.Console.WriteLine();
    }
}
void ArifmeticMeanArray2D(double[,] array2D)
{
    for(var j = 0; j<array2D.GetLength(1); j++) 
    {
        double summ = 0;
        for(var i = 0; i<array2D.GetLength(0); i++) 
        {
          summ += array2D[i,j]; // Элементы каждого столбца складываем, 
        }
        double arifmeticMean = summ / array2D.GetLength(0); //  затем делим полученную сумму на количество элементов в столбце.
        System.Console.Write("  " + Math.Round(arifmeticMean, 1) + "  ");
    }
}
int m = 3;
int n = 4;
double[,] newArray2D = new double[m, n];
FillArray2D(newArray2D);
PrintArray2D(newArray2D);
System.Console.WriteLine();
ArifmeticMeanArray2D(newArray2D);
System.Console.WriteLine();
