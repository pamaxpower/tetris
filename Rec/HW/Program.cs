/*

*/

Console.Clear();




void EvenNumRec(int m, int n)                               // Четные натуральные числа
{
    if (m > n) return;
    if (m % 2 == 0)
    {
        Console.Write($"{m} ");
    }
    EvenNumRec(m+1,n);
}
int SumNumberRec (int a, int b)                             // Сумма чисел
{
    int sum = 0;
    if (a <= b) 
    {
        sum = a + SumNumberRec(a+1,b);
    }
    return sum;
}
int GreatestCommonDivisitor(int a, int b)                   // Наибольший общий делитель
{
    int gcd = 0;
    if (a < 0) return gcd = GreatestCommonDivisitor(-a, b);     // Если числа отрицательные
    if (b < 0) return gcd = GreatestCommonDivisitor(a, -b);
    if (a == 0) return gcd = b;                                 // ноль делится на любое число
    if (b == 0) return gcd = a;
    if (a == b) return gcd = a;
    if (a == 1 && b == 1) return gcd = 1;                       // единица имеет только один делитель: 1
    if (a % b > 0)                                              // Остаток от деления больше 0
    {
        return gcd = GreatestCommonDivisitor(b, a % b);
    }
    else return b;
}
int FunctionAkkerman(int a, int b)                          // Функция Аккермана
{
    if (a == 0) return b + 1;
    if (b == 0) return FunctionAkkerman(a - 1, 1);
    return FunctionAkkerman(a - 1, FunctionAkkerman(a, b - 1));
}

