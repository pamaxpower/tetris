﻿/* все чётные натуральные числа в промежутке от M до N с помощью рекурсии.

M = 1; N = 5 -> 2, 4
M = 4; N = 8 -> 4, 6, 8
*/

int a = 1071;
int b = 462;

while (a % b != 0)
{
    int c = a % b;
    Console.WriteLine(c);
    a = c;
}

