//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int SummNum(int Num)
{// фнукция возвращает сумму цифр числа.
    int st=0;
    while (Num > 0 )
        {
        st=st+Num%10;
        Num=Num/10;
        }
    return st;
}

Console.WriteLine("Задача 27.Программа, которая принимает на вход число и выдаёт сумму цифр в числе.");
Console.Write("Введите число:");
int a=Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"сумма цифр сисла {a} равна:{SummNum(a)}");