// Поворот массива

Console.Clear();

void PrintArray (int [,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            if (inputArray[i,j] == 1) Console.Write("# ");
            else Console.Write(". ");
        }
        Console.WriteLine();
    }
}

int[,] TurnArrayRigth (int[,] arr)
{
    int[,] turnArrayRigth = new int[arr.GetLength(0), arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
        turnArrayRigth[i, j] = arr[arr.GetLength(0)-j-1, i];
        }
    }
    return turnArrayRigth;
}

int[,] TurnArrayLeft (int[,] arr)
{
    int[,] turnArrayLeft = new int[arr.GetLength(0), arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
        turnArrayLeft[i, j] = arr[j,arr.GetLength(0)-1-i];
        }
    }
    return turnArrayLeft;
}


int[,] array = new int [3,3] {
{ 1,1,0 },
{ 1,0,0 },
{ 1,0,0 }
};

PrintArray(array);

string exit = "n";
while (exit == "n")
{
Console.WriteLine();
Console.WriteLine("Нажмите d, чтобы повернуть фигуру вправо и a, чтобы повернуть влево");
string next = Console.ReadLine();



    if (next == "d")
    {
        TurnArrayRigth(array);
        PrintArray(TurnArrayRigth(array));
        array = TurnArrayRigth(array);
    }
    if (next == "a")
    {
        TurnArrayLeft(array);
        PrintArray(TurnArrayLeft(array));
        array = TurnArrayLeft(array);
    }


Console.WriteLine();
Console.Write("Выйти? (y/n): ");
exit = Console.ReadLine();
}

