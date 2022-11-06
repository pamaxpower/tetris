/* Калякулятор системы экспрессов ставок
Чтобы определить количество вариантов экспрессов для вида системы x из y, где x-количество матчей в одном экспрессе , а y - общее кол-во матчей
*/

Console.Clear();

// Console.Write("Введите вид системы: ");
// int x = Convert.ToInt32(Console.ReadLine());
// int y = Convert.ToInt32(Console.ReadLine());
int x = 2;
int y = 5;

double countCombinations = Math.Pow(2,y);

int[] ConvertNum10ToNum2 (int num)                       // Перевод в двоичное число
{
    int[] b = new int[y];
    for (int i = 0; num >= 1; i++)                    // Деление на 2
        {
            int a = Convert.ToInt32(num) % 2;
            b[i] = a;
            num = num / 2;
        }
    Array.Reverse(b);
    return b;
}
int [] arrayTo2 = ConvertNum10ToNum2((int)countCombinations-1); // int[] arr

//Console.WriteLine(String.Join(",", arrayTo2));


// Console.Write("Введите коэффициенты: ");
// double ev1 = Convert.ToDouble(Console.ReadLine());
// double ev2 = Convert.ToDouble(Console.ReadLine());
// double ev3 = Convert.ToDouble(Console.ReadLine());
// double ev4 = Convert.ToDouble(Console.ReadLine());
// double ev5 = Convert.ToDouble(Console.ReadLine());
// double [] arrayRatio = {ev1,ev2,ev3,ev4,ev5}; // int[] rat

double [] arrayRatio = {1,2,3,4,5};

//Console.WriteLine(String.Join(", ", arrayRatio));

double [] Combination (double[] rat, int len)
{
    double[] exp = new double [rat.Length];

    for (int i = 1; i < countCombinations-1; i++)
    {
        //int i = 11;
        int[] arr = ConvertNum10ToNum2(i);
        Console.WriteLine(String.Join(",", arr));

        for (int j = 0; j < arr.Length; j++)
        {
            if (arr[j] == 1) exp[j] = rat[j];
            else exp[j] = 0; 
        }

        Console.WriteLine(String.Join(",",exp));
        Console.WriteLine();
    }
    return exp;
}

Combination(arrayRatio,x);

