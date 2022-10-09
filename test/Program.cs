// int[,] array = new int[4,4] {
//     { 1,2,3,4 },
//     { 5,6,7,8 },
//     { 9,0,1,2 },
//     { 3,4,5,6 }
// };

Console.Clear();

int[,] array = FillArray(3, 3, 1 , 9);
PrintArray(array);
Console.WriteLine();

int[,] rotated = RotateMatrix(array, 3);

PrintArray(rotated); 

static int[,] RotateMatrix(int[,] matrix, int n)
{
    int[,] ret = new int[n, n];

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            ret[i, j] = matrix[n - j - 1, i];
        }
    }

    return ret;
}

int[,] FillArray  (int rows, int columns, int min, int max)
{
    int[,] filledArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            filledArray[i, j] = new Random().Next(min, max + 1);
        }
    }
    return filledArray;
}

void PrintArray (int [,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(" " + inputArray[i,j]);
        }
        Console.WriteLine();
    }
}



