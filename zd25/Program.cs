//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Pow(int A,B)
{// фнукция возво дит число А в степень B.
int st=1;
while (B > 0 )
{
    st=st*a;
    B--;
}
return st;
}

Console.WriteLine("Задача 25: Программа, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");
Console.Write("Введите чиссло А:");
int A=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите чиссло B:");
int A=Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Число A в степени B равно:{power(A,B)}");