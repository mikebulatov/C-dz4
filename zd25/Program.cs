//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int Power(int A,int B)
{// фнукция возводит число А в степень B.
    int st=1;
    while (B > 0 )
        {
        st=st*A;
        B--;
        }
    return st;
}

Console.WriteLine("Задача 25: Программа, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");
Console.Write("Введите чиссло А:");
int a=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите чиссло B:");
int b=Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Число {a} в степени {b} равно:{Power(a,b)}");