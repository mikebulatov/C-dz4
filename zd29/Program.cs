//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Console.WriteLine("Задача 27.Программа, задаёт массив из 8 элементов и выводит их на экран");
int [] mass=new int [8];

void CrateArray()
{
for(int i=0; i<mass.Length; i++)
    {
        mass[i]= new Random().Next(0,999);
        }
}
//_________________________________________________________


CrateArray();
Console.Write("Сформированный массив:");
for(int i=0; i<mass.Length; i++)
    {
                Console.Write(mass[i]);
        Console.Write(" ");
    }
Console.WriteLine();