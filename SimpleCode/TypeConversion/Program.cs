/* Преобразование и приведение примитивный типов в C#
- процесс перевода (конвертации) объекта одного типа данных в другой
int (в коде), float(в методе) - неявное преобразование (implicit) - происходит автоматически
double(в коде), float(в методе) - невозможно неявно конвертировать - требуется вручную сделать явное преобразование (explicit)
*/
double a = 5.3;
float b = (float)a;
/* Каким будет преобразование, явным или неявным, можно определить по диапазону данных типа переменной. 
Если диапазон изначального типа переменной меньше, чем конечного, то преобразование будет явным.*/

/* Сужающее преобразование - явное приведение типов - мы сужаем диапазон значений начальной переменной
Расширяющее преобразование - неявное преобразование - из меньшего типа данный перемещаем в больший */

int c = 300;
byte d = (byte)c;               // Произошло переполнение данных. Тип byte вмешает в себя диапазон значений от 0 до 255.
System.Console.WriteLine(d);    // При переполнении диапазона счет идет сначала. Поэтому 300 в диапазоне byte бдет равно 300-256=44

int m = 5;
float n = 2.5f;                 // постфикс f указывает, что это число типа float. Без него, по умолчанию, программа считает, что это double
// float n = (float)m           // также верна и эта запись
float result = m + n;           
Console.WriteLine(result);