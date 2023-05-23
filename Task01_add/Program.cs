// Задача необязательная 1: на входе целое или вещественное число, надо удалить вторую цифру слева этого числа.
// 145 -> 15
// 1 -> нет
// 567,123 -> 57,123

Console.Clear();
System.Console.Write("Введите число: ");
double num = Convert.ToDouble(Console.ReadLine());
int count = 0;

if (num<10) // Если число меньше 10, то нужно довести его до 2х значного числа, 
            // потом убрать значения после запятой, предварительно сохранив их. 
            // После разделить на 10 без остатка, и к новому значению прибавить значения после запятой
{
    num=num*10;
    int numInt = Convert.ToInt32(Math.Floor(num));
    double onlydouble = num-numInt;
    int newNumInt=numInt/10;
    double result=newNumInt+onlydouble;
    System.Console.WriteLine(result);
}

else        // Если число больше 100, то нужно довести его до 2х значного числа, путем разделения на 10 
            // и запомнить сколько раз это сделали,
            // потом убрать значения после запятой, предварительно сохранив их. 
            // После разделить на 10 без остатка, и к новому значению прибавить значения после запятой
            // и умножить на столько сколько раз разделили на 10.
{
    while (num > 100)
    {
        num = num / 10;
        count = count + 1;
    }
    int numInt = Convert.ToInt32(Math.Floor(num));
    double onlydouble = num - numInt;
    int newNumInt = numInt / 10;
    double sum = newNumInt + onlydouble;
    double result = sum * Math.Pow(10, count);
    System.Console.WriteLine(result);
}

